using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Kinect;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
namespace kin
{
    public partial class gaitAnalysis : Form
    {
        static KinectSensor sensor;
        Skeleton skeleton;
        Graphics graphicsFromBtmp;
        static SystemDB sysDB;

        int frame = 0;
        DateTime startTime;
        DateTime time;
        DateTime terminateTime;
        double timeInSecond = 0;
        bool testStart = false;

        //Gait Parameters
        double cadence = 0;             //What is this?
        public double stepLength = 0;          //Done
        double stepTime = 0;            //Done
        double stepWidth = 0;           //What is this?
        public double stepFrequency = 0;       //Done
        double stanceTime = 0;          //Done
        double strideLength = 0;        //Done
        public double strideVelocity = 0;      //Done (Edit)
        double swingTime = 0;           //Done

        double totalDistance = 0;
        double[] initialPoint = new double[3];
        double[] currentPoint = new double[3];

        double totalTime = 0;
        double initialTime = 0;
        double currentTime = 0;

        int stanceCounter = 0;
        double stanceTimeTotal = 0;
        double initialStanceTime = 0;
        double terminalStanceTime = 0;

        int swingCounter = 0;
        double swingTimeTotal = 0;
        double initialSwingTime = 0;
        double terminalSwingTime = 0;

        int stepCounter = 0;
        bool stepProcessingLeft = false;
        bool stepProcessingRight = false;
        double stepTimeTotal = 0;
        double initialStepTime = 0;
        double terminalStepTime = 0;

        double stepLengthTotal = 0;
        double[,] initialStepPoint = new double[2, 3];
        double[,] terminalStepPoint = new double[2, 3];

        int strideCounter = 0;
        bool strideProcessingLeft = false;
        bool strideProcessingRight = false;
        double strideLengthTotal = 0;
        double[,] initialStridePoint = new double[2, 3];
        double[,] terminalStridePoint = new double[2, 3];

        bool leftOnFloor = true;
        bool rightOnFloor = true;
        double leftOnFloorTrue = 0;
        double leftOnFloorFalse = 0;
        double rightOnFloorTrue = 0;
        double rightOnFloorFalse = 0;
        bool stance = false;

        private Skeleton[] skeletons = null;
        Tuple<float, float, float, float> floorPlane;

        public gaitAnalysis()
        {
            InitializeComponent();
            sensor = KinectSensor.KinectSensors.Where(s => s.Status == KinectStatus.Connected).FirstOrDefault();
        }
       

        private void gaitAnalysis_Load(object sender, EventArgs e)
        {
            if (sensor == null)
            {
                noKinectWarn.Visible = true;
                startBtn.Enabled = false;
                stopBtn.Enabled = false;
            }
            else
            {
                noKinectWarn.Visible = false;
                videoBox.Visible = true;
                startBtn.Enabled = true;
                stopBtn.Enabled = true;

                //set up sensor
                sensor.ColorStream.Enable(ColorImageFormat.RgbResolution640x480Fps30);
                sensor.DepthStream.Enable(DepthImageFormat.Resolution640x480Fps30);
                sensor.SkeletonStream.Enable();
                sensor.SkeletonStream.TrackingMode = SkeletonTrackingMode.Default;

                
                sensor.ColorFrameReady += new EventHandler<ColorImageFrameReadyEventArgs>(kinectSensor_ColorFrameReady);
                sensor.SkeletonFrameReady += sensor_SkeletonFrameReady;
                sensor.Start();
            }
        }

        private void sensor_SkeletonFrameReady(object sender, SkeletonFrameReadyEventArgs e)
        {
            using (SkeletonFrame skeletonFrame = e.OpenSkeletonFrame())
            {
                //floorPlane = skeletonFrame.FloorClipPlane;

                if (skeletonFrame != null)
                {
                    if (this.skeletons == null)
                    {
                        this.skeletons = new Skeleton[skeletonFrame.SkeletonArrayLength];
                    }

                    skeletonFrame.CopySkeletonDataTo(this.skeletons);
                    this.skeleton = this.skeletons.Where(s => s.TrackingState == SkeletonTrackingState.Tracked).FirstOrDefault();
                    floorPlane = skeletonFrame.FloorClipPlane;
                    
                    DrawStandingSkeletons(skeletons);
                }
                else
                {
                    statusLbl.ForeColor = Color.Red;
                    statusLbl.Text = "No skeleton detected!";
                }
            }
        }

        private void DrawStandingSkeletons(Skeleton[] skeletons)
        {
            //Console.Write("DETECT\n");
            foreach (Skeleton skel in skeletons)
            {
                if (skel.TrackingState == SkeletonTrackingState.Tracked)
                {
                    //torso
                    this.DrawBone(skel,  JointType.Head, JointType.ShoulderCenter);
                    this.DrawBone(skel,  JointType.ShoulderCenter, JointType.ShoulderLeft);
                    this.DrawBone(skel,  JointType.ShoulderCenter, JointType.ShoulderRight);
                    this.DrawBone(skel,  JointType.ShoulderCenter, JointType.Spine);
                    this.DrawBone(skel,  JointType.Spine, JointType.HipCenter);
                    this.DrawBone(skel,  JointType.HipCenter, JointType.HipLeft);
                    this.DrawBone(skel,  JointType.HipCenter, JointType.HipRight);

                    // Left Arm
                    this.DrawBone(skeleton,  JointType.ShoulderLeft, JointType.ElbowLeft);
                    this.DrawBone(skeleton,  JointType.ElbowLeft, JointType.WristLeft);
                    this.DrawBone(skeleton,  JointType.WristLeft, JointType.HandLeft);

                    // Right Arm
                    this.DrawBone(skeleton,  JointType.ShoulderRight, JointType.ElbowRight);
                    this.DrawBone(skeleton,  JointType.ElbowRight, JointType.WristRight);
                    this.DrawBone(skeleton,  JointType.WristRight, JointType.HandRight);
                    //Left Leg
                    this.DrawBone(skel, JointType.HipLeft, JointType.KneeLeft);
                    this.DrawBone(skel, JointType.KneeLeft, JointType.AnkleLeft);
                    this.DrawBone(skel, JointType.AnkleLeft, JointType.FootLeft);

                    // Right Leg
                    this.DrawBone(skel, JointType.HipRight, JointType.KneeRight);
                    this.DrawBone(skel, JointType.KneeRight, JointType.AnkleRight);
                    this.DrawBone(skel, JointType.AnkleRight, JointType.FootRight);
                }
            }
        }

        private void DrawBone(Skeleton skel, JointType jointType0, JointType jointType1)
        {
            Joint joint0 = skel.Joints[jointType0];
            Joint joint1 = skel.Joints[jointType1];

            if (joint0.TrackingState == JointTrackingState.Tracked && joint1.TrackingState == JointTrackingState.Tracked)
            {
                graphicsFromBtmp = videoBox.CreateGraphics();
                    graphicsFromBtmp.Clear(Color.Transparent);
                    Pen p = new Pen(Color.Blue, 2.0f);
                    graphicsFromBtmp.DrawLine(p, SkeletonPointToScreen(joint0.Position), SkeletonPointToScreen(joint1.Position));
            }
        }

        private Point SkeletonPointToScreen(SkeletonPoint skelpoint)
        {
            DepthImagePoint depthPoint = sensor.CoordinateMapper.MapSkeletonPointToDepthPoint(skelpoint, DepthImageFormat.Resolution640x480Fps30);
            return new Point(depthPoint.X, depthPoint.Y);
        }

        private void captureValues(Skeleton skeleton)
        {
            {
                Joint kneeLeft = skeleton.Joints[JointType.KneeLeft];
                Joint kneeRight = skeleton.Joints[JointType.KneeRight];
                Joint ankleLeft = skeleton.Joints[JointType.AnkleLeft];
                Joint ankleRight = skeleton.Joints[JointType.AnkleRight];
                Joint footLeft = skeleton.Joints[JointType.FootLeft];
                Joint footRight = skeleton.Joints[JointType.FootRight];


                if ((ankleLeft.TrackingState == JointTrackingState.Tracked && ankleLeft.TrackingState == JointTrackingState.Tracked) && (footLeft.TrackingState == JointTrackingState.Tracked && footLeft.TrackingState == JointTrackingState.Tracked) && (kneeLeft.TrackingState == JointTrackingState.Tracked && kneeLeft.TrackingState == JointTrackingState.Tracked))
                {
                    time = DateTime.Now;
                    timeInSecond = time.Minute * 60 + time.Second;
                    timeLbl.Text = "Time: " + timeInSecond +" s";

                    float leftFootFloorDistance = (float)Math.Round(Math.Abs((floorPlane.Item1 * footLeft.Position.X) + (floorPlane.Item2 * footLeft.Position.Y) + (floorPlane.Item3 * footLeft.Position.Z) + floorPlane.Item4) / Math.Sqrt(Math.Pow(footLeft.Position.X, 2) + Math.Pow(footLeft.Position.Y, 2) + Math.Pow(footLeft.Position.Z, 2)) * 1000, 2);
                    float rightFootFloorDistance = (float)Math.Round(Math.Abs((floorPlane.Item1 * footRight.Position.X) + (floorPlane.Item2 * footRight.Position.Y) + (floorPlane.Item3 * footRight.Position.Z) + floorPlane.Item4) / Math.Sqrt(Math.Pow(footRight.Position.X, 2) + Math.Pow(footRight.Position.Y, 2) + Math.Pow(footRight.Position.Z, 2)) * 1000, 2);

                    //Improve Accuracy Calibration (Disregard bad skeletons)
                    if (leftFootFloorDistance < 10)
                    {
                        if (leftOnFloorFalse < 5)
                            leftOnFloorFalse = 0;
                        if (++leftOnFloorTrue == 6)
                        {
                            leftOnFloor = true;
                            leftOnFloorTrue = 0;
                            leftOnFloorFalse = 0;
                        }
                    }
                    else
                    {
                        if (leftOnFloorTrue < 5)
                            leftOnFloorTrue = 0;
                        if (++leftOnFloorFalse == 6)
                        {
                            leftOnFloor = false;
                            leftOnFloorTrue = 0;
                            leftOnFloorFalse = 0;
                        }
                    }

                    if (rightFootFloorDistance < 10)
                    {
                        if (rightOnFloorFalse < 5)
                            rightOnFloorFalse = 0;
                        if (++rightOnFloorTrue == 6)
                        {
                            rightOnFloor = true;
                            rightOnFloorTrue = 0;
                            rightOnFloorFalse = 0;
                        }
                    }
                    else
                    {
                        if (rightOnFloorTrue < 5)
                            rightOnFloorTrue = 0;
                        if (++rightOnFloorFalse == 6)
                        {
                            rightOnFloor = false;
                            rightOnFloorTrue = 0;
                            rightOnFloorFalse = 0;
                        }
                    }

                    stance = leftOnFloor && rightOnFloor;

                    if (stance)
                    {
                        //Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        //Console.BackgroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        //Console.Clear();
                        if (!leftOnFloor && !rightOnFloor)
                            Console.ForegroundColor = ConsoleColor.White;
                        else if (!leftOnFloor)
                            Console.ForegroundColor = ConsoleColor.Blue;
                        else if (!rightOnFloor)
                            Console.ForegroundColor = ConsoleColor.Green;
                        //Console.BackgroundColor = ConsoleColor.Green;
                    }

                    //Stride Velocity
                    if (initialPoint[0] == 0 && initialPoint[1] == 0 && initialPoint[2] == 0)
                    {
                        initialPoint[0] = footLeft.Position.X;
                        initialPoint[1] = footLeft.Position.Y;
                        initialPoint[2] = footLeft.Position.Z;
                        initialTime = timeInSecond;
                        startTime = DateTime.Now;
                    }
                    else
                    {
                        currentPoint[0] = footLeft.Position.X;
                        currentPoint[1] = footLeft.Position.Y;
                        currentPoint[2] = footLeft.Position.Z;
                        currentTime = timeInSecond;

                        totalDistance = Math.Round(Math.Sqrt(Math.Pow(initialPoint[0] - currentPoint[0], 2) + Math.Pow(initialPoint[0] - currentPoint[0], 2) + Math.Pow(initialPoint[0] - currentPoint[0], 2)) * 100, 2);
                        totalTime = currentTime - initialTime;

                        strideVelocity = Math.Round(totalDistance / totalTime, 2);
                    }

                    //Step Length and Step Frequency (Right Foot)

                    if (!rightOnFloor)
                    {
                        if (!stepProcessingRight)
                        {
                            stepProcessingRight = true;
                            initialStepPoint[1, 0] = footRight.Position.X;
                            initialStepPoint[1, 1] = footRight.Position.Y;
                            initialStepPoint[1, 2] = footRight.Position.Z;
                            initialStepTime = timeInSecond;
                        }
                        else
                        {
                            terminalStepPoint[1, 0] = footRight.Position.X;
                            terminalStepPoint[1, 1] = footRight.Position.Y;
                            terminalStepPoint[1, 2] = footRight.Position.Z;
                            terminalStepTime = timeInSecond;
                        }
                    }

                    else
                    {
                        if (stepProcessingRight)
                        {
                            stepProcessingRight = false;

                            ++stepCounter;
                            stepLengthTotal += Math.Round(Math.Sqrt(Math.Pow(initialStepPoint[1, 0] - terminalStepPoint[1, 0], 2) + Math.Pow(initialStepPoint[1, 1] - terminalStepPoint[1, 1], 2) + Math.Pow(initialStepPoint[1, 2] - terminalStepPoint[1, 2], 2)) * 100, 2);
                            stepLength = Math.Round(stepLengthTotal / stepCounter, 2);

                            stepTimeTotal += terminalStepTime - initialStepTime;
                            stepTime = Math.Round(stepTimeTotal / stepCounter, 2);

                            stepFrequency = Math.Round(stepCounter / (totalTime), 2);

                            initialStepPoint[1, 0] = 0;
                            initialStepPoint[1, 1] = 0;
                            initialStepPoint[1, 2] = 0;
                            initialStepTime = 0;

                            terminalStepPoint[1, 0] = 0;
                            terminalStepPoint[1, 1] = 0;
                            terminalStepPoint[1, 2] = 0;
                            terminalStepTime = 0;
                        }
                    }

                    //Step Length and Step Frequency (Left Foot)
                    if (!leftOnFloor)
                    {
                        if (!stepProcessingLeft)
                        {
                            stepProcessingLeft = true;
                            initialStepPoint[0, 0] = footLeft.Position.X;
                            initialStepPoint[0, 1] = footLeft.Position.Y;
                            initialStepPoint[0, 2] = footLeft.Position.Z;
                            initialStepTime = timeInSecond;
                        }
                        else
                        {
                            terminalStepPoint[0, 0] = footLeft.Position.X;
                            terminalStepPoint[0, 1] = footLeft.Position.Y;
                            terminalStepPoint[0, 2] = footLeft.Position.Z;
                            terminalStepTime = timeInSecond;
                        }
                    }

                    else
                    {
                        if (stepProcessingLeft)
                        {
                            stepProcessingLeft = false;

                            ++stepCounter;
                            stepLengthTotal += Math.Round(Math.Sqrt(Math.Pow(initialStepPoint[0, 0] - terminalStepPoint[0, 0], 2) + Math.Pow(initialStepPoint[0, 1] - terminalStepPoint[0, 1], 2) + Math.Pow(initialStepPoint[0, 2] - terminalStepPoint[0, 2], 2)) * 100, 2);
                            stepLength = Math.Round(stepLengthTotal / stepCounter, 2);

                            stepTimeTotal += terminalStepTime - initialStepTime;
                            stepTime = Math.Round(stepTimeTotal / stepCounter, 2);

                            stepFrequency = Math.Round(stepCounter / (totalTime), 2);

                            initialStepPoint[0, 0] = 0;
                            initialStepPoint[0, 1] = 0;
                            initialStepPoint[0, 2] = 0;
                            initialStepTime = 0;

                            terminalStepPoint[0, 0] = 0;
                            terminalStepPoint[0, 1] = 0;
                            terminalStepPoint[0, 2] = 0;
                            terminalStepTime = 0;
                        }
                    }

                    //Stride Length (Left Foot)
                    if (stance && strideProcessingLeft)
                    {
                        strideProcessingLeft = false;
                        initialStridePoint[1, 0] = footRight.Position.X;
                        initialStridePoint[1, 1] = footRight.Position.Y;
                        initialStridePoint[1, 2] = footRight.Position.Z;

                        terminalStridePoint[1, 0] = footLeft.Position.X;
                        terminalStridePoint[1, 1] = footLeft.Position.Y;
                        terminalStridePoint[1, 2] = footLeft.Position.Z;

                        ++strideCounter;
                        strideLengthTotal += Math.Round(Math.Sqrt(Math.Pow(initialStridePoint[1, 0] - terminalStridePoint[1, 0], 2) + Math.Pow(initialStridePoint[1, 1] - terminalStridePoint[1, 1], 2) + Math.Pow(initialStridePoint[1, 2] - terminalStridePoint[1, 2], 2)) * 100, 2);
                        strideLength = Math.Round(strideLengthTotal / strideCounter, 2);
                    }

                    //Stride Length (Right Foot)
                    /*if (leftOnFloor)
                    {
                        if (!strideProcessingRight)
                        {
                            strideProcessingRight = true;
                            initialStridePoint[0, 0] = footLeft.Position.X;
                            initialStridePoint[0, 1] = footLeft.Position.Y;
                            initialStridePoint[0, 2] = footLeft.Position.Z;
                        }

                        if (!rightOnFloor)
                        {
                            terminalStridePoint[0, 0] = footRight.Position.X;
                            terminalStridePoint[0, 1] = footRight.Position.Y;
                            terminalStridePoint[0, 2] = footRight.Position.Z;

                        }

                        else
                        {
                            if (strideProcessingRight)
                            {

                                strideProcessingRight = false;
                                ++strideCounter;
                                strideLengthTotal += Math.Round(Math.Sqrt(Math.Pow(initialStridePoint[0, 0] - terminalStridePoint[0, 0], 2) + Math.Pow(initialStridePoint[0, 1] - terminalStridePoint[0, 1], 2) + Math.Pow(initialStridePoint[0, 2] - terminalStridePoint[0, 2], 2)) * 100, 2);
                                strideLength = Math.Round(strideLengthTotal / strideCounter, 2);

                                initialStridePoint[0, 0] = 0;
                                initialStridePoint[0, 1] = 0;
                                initialStridePoint[0, 2] = 0;

                                terminalStridePoint[0, 0] = 0;
                                terminalStridePoint[0, 1] = 0;
                                terminalStridePoint[0, 2] = 0;
                            }
                        }
                    }*/

                    //Stance Time and Swing Time
                    if (stance)
                    {
                        if (!(initialSwingTime == 0))
                        {
                            ++swingCounter;
                            swingTimeTotal += terminalSwingTime - initialSwingTime;
                            swingTime = Math.Round(swingTimeTotal / swingCounter);
                        }

                        if (initialStanceTime == 0)
                            initialStanceTime = timeInSecond;
                        else
                            terminalStanceTime = timeInSecond;
                    }

                    if (!stance)
                    {
                        strideProcessingLeft = true;
                        if (!(initialStanceTime == 0))
                        {
                            ++stanceCounter;
                            stanceTimeTotal += terminalStanceTime - initialStanceTime;
                            stanceTime = Math.Round(stanceTimeTotal / stanceCounter);
                        }

                        if (initialSwingTime == 0)
                            initialSwingTime = timeInSecond;
                        else
                            terminalSwingTime = timeInSecond;
                    }

                    if (frame % 300 == 9)
                        //Console.Clear();

                    Console.WriteLine("Frame: " + ++frame);
                    Console.WriteLine();
                    Console.WriteLine("Gait Parameters");
                    Console.WriteLine("Step Length: " + stepLength + "cm");
                    Console.WriteLine("Step Time: " + stepTime + "s");
                    Console.WriteLine("Step Frequency: " + stepFrequency + " steps/sec");
                    Console.WriteLine("Stride Length: " + strideLength + "cm");
                    Console.WriteLine("Stride Velocity: " + strideVelocity + "cm/s");
                    Console.WriteLine("Stance Time: " + stanceTime + "s");
                    Console.WriteLine("Swing Time: " + swingTime + "s");
                    //Console.WriteLine();
                    //Console.WriteLine("Step Counter: " + stepCounter + " step/s");
                    //Console.WriteLine("Stride Counter: " + strideCounter + " step/s");
                    /*Console.WriteLine("Left Foot distance from Floor: " + leftFootFloorDistance);
                    Console.WriteLine("Right Foot distance from Floor: " + rightFootFloorDistance);
                    Console.WriteLine("Stance Status: " + stance);*/
                    //Console.WriteLine("Distance Traveled: " + totalDistance + "cm");
                    //Console.WriteLine("Time Traveled: " + totalTime + "s");
                    /*Console.WriteLine();
                    Console.WriteLine("Start Time: " + startTime.Hour + ":" + startTime.Minute + ":" + startTime.Second);
                    Console.WriteLine("Current Time: " + time.Hour + ":" + time.Minute + ":" + time.Second);*/
                    Console.WriteLine();
                }
            }
            /*else
            {
                terminateTime = DateTime.Now;
                if (timeInSecond + 5 == terminateTime.Minute * 60 + terminateTime.Second)
                {
                    Console.Clear();
                    return;
                }
            }*/
        }

        private void kinectSensor_ColorFrameReady(object sender, ColorImageFrameReadyEventArgs e)
        {
            ColorImageFrame colorFrame = e.OpenColorImageFrame();
            if (colorFrame == null)
            {
                return;
            }
            Bitmap bitmapFrame = ColorImageFrameToBitmap(colorFrame);
            videoBox.Image = bitmapFrame;

            graphicsFromBtmp = Graphics.FromImage(bitmapFrame);
        }


        private static Bitmap ColorImageFrameToBitmap(ColorImageFrame colorFrame)
        {
            byte[] pixelBuffer = new byte[colorFrame.PixelDataLength];
            colorFrame.CopyPixelDataTo(pixelBuffer);

            Bitmap bitmapFrame = new Bitmap(colorFrame.Width, colorFrame.Height,
                PixelFormat.Format32bppRgb);


            BitmapData bitmapData = bitmapFrame.LockBits(new Rectangle(0, 0,
                                             colorFrame.Width, colorFrame.Height),
            ImageLockMode.WriteOnly, bitmapFrame.PixelFormat);

            IntPtr intPointer = bitmapData.Scan0;
            Marshal.Copy(pixelBuffer, 0, intPointer, colorFrame.PixelDataLength);


            bitmapFrame.UnlockBits(bitmapData);


            return bitmapFrame;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Start");
            if (skeleton != null)
            {
                MessageBox.Show("start capture");
                captureValues(skeleton);
                MessageBox.Show("Analyzing");
            }
            else
            {
                statusLbl.Text = "No Skeleton detected";
                statusLbl.ForeColor = Color.Red;
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            sysDB = new SystemDB(); //values of gender and age should come from db
            int age = sysDB.getAge(1);
            char gender = sysDB.getGender(1);
            
            String output = "";
            output += String.Format(sysDB.AnalyzeData("spd", age, gender, strideVelocity) + "\n" + "Your stride velocity is: " + strideVelocity + " cm/s\n");
            output += String.Format(sysDB.AnalyzeData("freq", age, gender, stepFrequency) + "\n" + "Your step frequency is: " + stepFrequency + " step/seconds\n");
            output += String.Format(sysDB.AnalyzeData("len", age, gender, stepLength) + "\n"  + "Your step length is: " + stepLength + " cm\n");
            MessageBox.Show(output);
        }
    }
}
