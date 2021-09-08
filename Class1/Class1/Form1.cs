using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class1
{
    public partial class Airport : Form
    {
        public Airport()
        {            
            InitializeComponent();
           
        }
        int mpanel10 = 20; int mpanel8 = 650; int mpanel81 = 650; int mpanel9 = 45; int mpanel4 = 60; int mpanel41 = 0; int mpanel5 = 0; int mpanel51 = 0; int mpanel6 = 0; int mpanel61 = 0; int mpanel11 = 100; int mpanel111 = 0; int mpanel2 = 100; int mpanel22 = 0; int mpanel3 = 120; int mpanel33 = 0;
        int mpanel7 = 0; Thread startfunction1, startfunction2, startfunction3, startfunction0;
        static Point pi = new Point(); Thread terminal1th, terminal2th, terminal3th;
        AirplaneClass plane = new AirplaneClass(pi, 50, Color.Azure);
        AirplaneClass plane1 = new AirplaneClass(pi, 50, Color.Azure);
        AirplaneClass plane2 = new AirplaneClass(pi, 50, Color.Azure);
        AirplaneClass plane3 = new AirplaneClass(pi, 50, Color.Azure);
        AirplaneClass plane4 = new AirplaneClass(pi, 50, Color.Azure);
        AirplaneClass plane5 = new AirplaneClass(pi, 50, Color.Azure);
        AirplaneClass plane6 = new AirplaneClass(pi, 50, Color.Azure);
        AirplaneClass hub1 = new AirplaneClass(pi, 50, Color.Azure);
        AirplaneClass hub2 = new AirplaneClass(pi, 50, Color.Azure);
        AirplaneClass hub3 = new AirplaneClass(pi, 50, Color.Azure);  
        bool mustlockrunway = false; bool mustlocktoland = false; bool mustlocktakeoff = false; bool mustlockminrunway1 = false; bool mustlockminrunway3 = false; bool mustlockhub3 = false; bool mustlockhub1 = false; bool mustlockminrunway2 = false; bool mustlockhub2 = false;
        //move panel 10
        public void movepanel10()
        {  mpanel10 = 20;
            while (mustlockrunway == true)
            {
                plane.setPosition(0, 23);
                Graphics imagegraphics = panel10.CreateGraphics();
                Thread.Sleep(50);
                //SolidBrush brush = new SolidBrush(Color.Black);
                imagegraphics.Clear(Color.DarkGray);
                imagegraphics.DrawImage(new Bitmap("Pics/plane3.png"), 0, plane.getPositionY(), 35, 35);
                imagegraphics.Dispose();
            } 
            while (mpanel10 >-35)
            {
                plane.setPosition(mpanel10, 23);
                Graphics imagegraphics = panel10.CreateGraphics();
                Thread.Sleep(50);
                imagegraphics.Clear(Color.DarkGray);
                imagegraphics.DrawImage(new Bitmap("Pics/plane3.png"), plane.getPositionX(), plane.getPositionY(), 35, 35);
                plane.movePlane(mpanel10, plane.getPositionY());
                imagegraphics.Dispose();
                mpanel10 -= 5;             
            }     
        }
        //move panel 8
        public void movepanel8()
        {
             mustlockrunway = true;               
                if (plane.getDestination() == "1" || plane.getDestination() == "2" || plane.getDestination() == "3")
                {
                    int y = 23;
                    while (mpanel8 > 125 || y > -35)
                    {
                        Graphics graphics = panel8.CreateGraphics();
                        Thread.Sleep(50);
                        graphics.Clear(Color.DarkGray);
                        if (plane1.getPositionX() >= 125)
                        {
                            plane1.setPosition(mpanel8, 23);
                            graphics.DrawImage(new Bitmap("Pics/plane3.png"), plane1.getPositionX(), plane1.getPositionY(), 35, 35);
                            graphics.Dispose();
                            mpanel8 -= 5;
                        }
                        else
                        {
                            plane1.setPosition(66, y);
                            graphics.DrawImage(new Bitmap("Pics/plane5.png"), plane1.getPositionX(), plane1.getPositionY(), 35, 35);
                            if (plane1.getPositionY() <= 9)
                            {
                                while (mustlocktoland == true){ }
                            }
                            graphics.Dispose();
                            y -= 5;
                        }
                        plane1.movePlane(mpanel8, plane1.getPositionY());
                    } panel8.Invalidate();
                }
                else if (plane.getDestination() == "0")
                {
                    while (mpanel81 > -34)
                    {
                        Graphics graphics = panel8.CreateGraphics();
                        Thread.Sleep(50);
                        graphics.Clear(Color.DarkGray);

                        plane1.setPosition(mpanel81, 23);
                        graphics.DrawImage(new Bitmap("Pics/plane3.png"), plane1.getPositionX(), plane1.getPositionY(), 35, 35);
                        graphics.Dispose();
                        mpanel81 -= 5;
                    }
                }
             mustlockrunway = false;
                   }
        //move parnel 9
        public void movepanel9()
        {
            mustlocktoland = true;
            if (hub1.getDestination() == "1")
            {
                while (mpanel9 > -35)
                {

                    plane2.setPosition(23, mpanel9);
                    Graphics graphics = panel9.CreateGraphics();
                    //SolidBrush brush = new SolidBrush(Color.Black);
                    Thread.Sleep(50);
                    graphics.Clear(Color.DarkGray);
                    graphics.DrawImage(new Bitmap("Pics/plane5.png"), plane2.getPositionX(), plane2.getPositionY(), 35, 35);
                    plane2.movePlane(mpanel9, plane2.getPositionY());
                    if (mpanel9 <= 20)
                    {
                        while (mustlockhub1 == true)
                        {

                        }
                        while (mustlockminrunway1 == true) { }
                    }
                    graphics.Dispose();



                    mpanel9 -= 5;


                }
                mustlocktoland = false;
            }
            else if (hub1.getDestination() == "2" || hub1.getDestination() == "3")
            {
                while (mpanel9 > -35)
                {

                    plane2.setPosition(23, mpanel9);
                    Graphics graphics = panel9.CreateGraphics();
                    //SolidBrush brush = new SolidBrush(Color.Black);
                    Thread.Sleep(50);
                    graphics.Clear(Color.DarkGray);
                    graphics.DrawImage(new Bitmap("Pics/plane5.png"), plane2.getPositionX(), plane2.getPositionY(), 35, 35);
                    plane2.movePlane(mpanel9, plane2.getPositionY());
                    if (mpanel9 <= 20)
                    {
                       
                        while (mustlockminrunway1 == true) { }
                    }
                    graphics.Dispose();



                    mpanel9 -= 5;


                }
                mustlocktoland = false;

            }

        }
        public void movepanel4()
        {
          
                mustlockminrunway1 = true;
                if (plane3.getDestination() == "1")
                {
                    while (mpanel4 > -34)
                    {

                        plane3.setPosition(19, mpanel4);
                        Graphics graphics = panel4.CreateGraphics();

                        //SolidBrush brush = new SolidBrush(Color.Black);
                        Thread.Sleep(50);

                        graphics.Clear(Color.DarkGray);
                        graphics.DrawImage(new Bitmap("Pics/plane5.png"), plane3.getPositionX(), plane3.getPositionY(), 35, 35);
                        plane3.movePlane(mpanel4, plane3.getPositionY());

                        graphics.Dispose();
                        mpanel4 -= 5;
                    }
                    plane3.setdestination(null);

                }
                else if (plane2.getDestination() == "2" || plane2.getDestination() == "3")
                {
                    if(hub2.getDestination()=="2"){
                    while (mpanel41 < 220)
                    {

                        plane3.setPosition(mpanel41, 15);
                        Graphics graphics = panel4.CreateGraphics();

                        //SolidBrush brush = new SolidBrush(Color.Black);
                        Thread.Sleep(50);

                        graphics.Clear(Color.DarkGray);
                        graphics.DrawImage(new Bitmap("Pics/plane.png"), plane3.getPositionX(), plane3.getPositionY(), 35, 35);
                        plane3.movePlane(mpanel41, plane3.getPositionY());
                        if (mpanel41 >=10)
                        {
                            while (mustlockhub2 == true) { }
                            while (mustlockminrunway2 == true) { }
                           
                        }
                        graphics.Dispose();
                        mpanel41 += 5;
                    }
                    }
                    else if (hub2.getDestination() == "3")
                    {
                        while (mpanel41 < 220)
                        {

                            plane3.setPosition(mpanel41, 15);
                            Graphics graphics = panel4.CreateGraphics();

                            //SolidBrush brush = new SolidBrush(Color.Black);
                            Thread.Sleep(50);

                            graphics.Clear(Color.DarkGray);
                            graphics.DrawImage(new Bitmap("Pics/plane.png"), plane3.getPositionX(), plane3.getPositionY(), 35, 35);
                            plane3.movePlane(mpanel41, plane3.getPositionY());
                            if (mpanel41 >= 10)
                            {
                                
                                while (mustlockminrunway2 == true) { }

                            }
                            graphics.Dispose();
                            mpanel41 += 5;
                        }
                    }
                }
             mustlockminrunway1 = false;

        }
        public void movepanel11()
        {
            mustlockhub1 = true;
            if (hub1.getlandinfo() == "1")
            {
                while (mpanel11 > 0)
                {

                    hub1.setPosition(19, mpanel11);
                    Graphics graphics = panel11.CreateGraphics();

                    //SolidBrush brush = new SolidBrush(Color.Black);
                    Thread.Sleep(50);
                    graphics.Clear(Color.DarkGray);
                    graphics.DrawImage(new Bitmap("Pics/plane5.png"), hub1.getPositionX(), hub1.getPositionY(), 35, 35);
                    hub1.movePlane(mpanel11, hub1.getPositionY());

                    graphics.Dispose();
                    mpanel11 -= 5;
                }
            }
            else if (hub1.getlandinfo() == "2")
            {
                while (mpanel111 < 222)
                {

                    hub1.setPosition(19, mpanel111);
                    Graphics graphics = panel11.CreateGraphics();

                    //SolidBrush brush = new SolidBrush(Color.Black);
                    Thread.Sleep(50);
                    graphics.Clear(Color.DarkGray);
                    graphics.DrawImage(new Bitmap("Pics/plane4.png"), hub1.getPositionX(), hub1.getPositionY(), 35, 35);
                   // hub1.movePlane(mpanel11, hub1.getPositionY());
                    if (mpanel111 >= 120)
                    {
                        while (mustlockminrunway1 == true) { }
                    }
                    graphics.Dispose();
                    mpanel111 += 5;
                }
                hub1.landing(null);
                if (hub1.getlandinfo() == null) { mustlockhub1 = false; }
                
            }

           

        }
        public void movepanel5()
        {
            mustlockminrunway2 = true;
            if (plane6.getDestination() == "3")
            {
                if (hub3.getDestination() == "3")
                {
                    while (mpanel5 < 220)
                    {

                        plane4.setPosition(mpanel5, 16);
                        Graphics graphics = panel5.CreateGraphics();

                        //SolidBrush brush = new SolidBrush(Color.Black);
                        Thread.Sleep(50);

                        graphics.Clear(Color.DarkGray);
                        graphics.DrawImage(new Bitmap("Pics/plane.png"), plane4.getPositionX(), plane4.getPositionY(), 35, 35);
                        plane4.movePlane(mpanel5, plane3.getPositionY());
                        if (mpanel5 >= 150)
                        {
                            while (mustlockhub3 == true) { }
                            while (mustlockminrunway3 == true) { }

                        }
                        graphics.Dispose();
                        mpanel5 += 5;
                    }
                }
                else if (hub3.getDestination() == "4")
                {
                    while (mpanel5 < 220)
                    {

                        plane4.setPosition(mpanel5, 16);
                        Graphics graphics = panel5.CreateGraphics();

                        //SolidBrush brush = new SolidBrush(Color.Black);
                        Thread.Sleep(50);

                        graphics.Clear(Color.DarkGray);
                        graphics.DrawImage(new Bitmap("Pics/plane.png"), plane4.getPositionX(), plane4.getPositionY(), 35, 35);
                        plane4.movePlane(mpanel5, plane3.getPositionY());
                        if (mpanel5 >= 150)
                        {

                            while (mustlockminrunway3 == true) { }

                        }
                       
                        graphics.Dispose();
                        mpanel5 += 5;
                    }
                }
            }
            else if (plane6.getDestination() == "2")
            {
                while (mpanel5 < 10 || mpanel51 >= -30)
                {

                    
                    Graphics graphics = panel5.CreateGraphics();

                    //SolidBrush brush = new SolidBrush(Color.Black);
                    Thread.Sleep(50);

                    graphics.Clear(Color.DarkGray);
                    if (mpanel5 < 10)
                    {
                        plane4.setPosition(mpanel5, 19);
                        graphics.DrawImage(new Bitmap("Pics/plane.png"), plane4.getPositionX(), plane4.getPositionY(), 35, 35);
                       // plane3.movePlane(mpanel41, plane3.getPositionY());

                        graphics.Dispose();
                        mpanel5 += 5;
                    }
                    else
                    {
                        plane4.setPosition(19, mpanel51);
                        graphics.DrawImage(new Bitmap("Pics/plane5.png"), plane4.getPositionX(), plane4.getPositionY(), 35, 35);
                       // plane3.movePlane(mpanel51, plane3.getPositionY());

                        graphics.Dispose();
                        mpanel51 -= 5;
                    }

                }
            } mustlockminrunway2 = false;


        }
        public void movepanel2()
        {
            mustlockhub2 = true;
            if (hub2.getlandinfo() == "1")
            {
            while (mpanel2 > 0)
            {

                hub2.setPosition(19, mpanel2);
                Graphics graphics = panel2.CreateGraphics();

                //SolidBrush brush = new SolidBrush(Color.Black);
                Thread.Sleep(50);
                graphics.Clear(Color.DarkGray);
                graphics.DrawImage(new Bitmap("Pics/plane5.png"), hub2.getPositionX(), hub2.getPositionY(), 35, 35);
                //hub1.movePlane(mpanel11, hub2.getPositionY());

                graphics.Dispose();
                mpanel2 -= 5;
            }
            }
            else if (hub2.getlandinfo() == "2")
            {
                while (mpanel22 < 222)
                {

                    hub2.setPosition(19, mpanel22);
                    Graphics graphics = panel2.CreateGraphics();

                    //SolidBrush brush = new SolidBrush(Color.Black);
                    Thread.Sleep(50);
                    graphics.Clear(Color.DarkGray);
                    graphics.DrawImage(new Bitmap("Pics/plane4.png"), hub2.getPositionX(), hub2.getPositionY(), 35, 35);
                    // hub1.movePlane(mpanel11, hub1.getPositionY());
                    if (mpanel22 >= 200)
                    {
                        while (mustlockminrunway2 == true) { }
                    }
                    graphics.Dispose();
                    mpanel22 += 5;
                }
                hub2.landing(null);
                if (hub2.getlandinfo() == null) { mustlockhub2 = false; }
            }


        }
        public void movepanel6()
        {
            mustlockminrunway3 = true;
            if (plane4.getDestination() == "4")
            {
                while (mpanel6 < 210)
                {

                    plane5.setPosition(mpanel6, 15);
                    Graphics graphics = panel6.CreateGraphics();

                    //SolidBrush brush = new SolidBrush(Color.Black);
                    Thread.Sleep(50);

                    graphics.Clear(Color.DarkGray);
                    graphics.DrawImage(new Bitmap("Pics/plane.png"), plane5.getPositionX(), plane5.getPositionY(), 35, 35);
                    //plane4.movePlane(mpanel5, plane3.getPositionY());
                    if (mpanel6 >= 140)
                    {
                        while (mustlocktakeoff == true) { }
                    }
                    graphics.Dispose();
                    mpanel6 += 5;
                }
            }
            else if (plane4.getDestination() == "3")
            {
                while (mpanel6 < 10 || mpanel61 >= -30)
                {


                    Graphics graphics = panel6.CreateGraphics();

                    //SolidBrush brush = new SolidBrush(Color.Black);
                    Thread.Sleep(50);

                    graphics.Clear(Color.DarkGray);
                    if (mpanel6 < 10)
                    {
                        plane5.setPosition(mpanel5, 19);
                        graphics.DrawImage(new Bitmap("Pics/plane.png"), plane5.getPositionX(), plane5.getPositionY(), 35, 35);
                        // plane3.movePlane(mpanel41, plane3.getPositionY());

                        graphics.Dispose();
                        mpanel6 += 5;
                    }
                    else
                    {
                        plane5.setPosition(19, mpanel61);
                        graphics.DrawImage(new Bitmap("Pics/plane5.png"), plane5.getPositionX(), plane5.getPositionY(), 35, 35);
                        // plane3.movePlane(mpanel51, plane3.getPositionY());

                        graphics.Dispose();
                        mpanel61 -= 5;
                    }

                }
            }
            mustlockminrunway3 = false;

        }
        public void movepanel3()
        {
            mustlockhub3 = true;
                if (hub3.getlandinfo() == "1")
            {
            while (mpanel3 > 0)
            {

                hub3.setPosition(19, mpanel3);
                Graphics graphics = panel3.CreateGraphics();

                //SolidBrush brush = new SolidBrush(Color.Black);
                Thread.Sleep(50);
                graphics.Clear(Color.DarkGray);
                graphics.DrawImage(new Bitmap("Pics/plane5.png"), hub3.getPositionX(), hub3.getPositionY(), 35, 35);
                //hub1.movePlane(mpanel11, hub2.getPositionY());

                graphics.Dispose();
                mpanel3 -= 5;
            }
            }
                else if (hub3.getlandinfo() == "2")
                {
                    while (mpanel33 < 222)
                    {

                        hub3.setPosition(19, mpanel33);
                        Graphics graphics = panel3.CreateGraphics();

                        //SolidBrush brush = new SolidBrush(Color.Black);
                        Thread.Sleep(50);
                        graphics.Clear(Color.DarkGray);
                        graphics.DrawImage(new Bitmap("Pics/plane4.png"), hub3.getPositionX(), hub3.getPositionY(), 35, 35);
                        // hub1.movePlane(mpanel11, hub1.getPositionY());
                        if (mpanel33 >= 130)
                        {

                            while (mustlockminrunway3 == true) { }

                        }
                        graphics.Dispose();
                        mpanel33 += 5;
                    }
                    hub3.landing(null);
                    if (hub3.getlandinfo() == null) { mustlockhub3 = false; }

                }



        }
        public void movepanel7()
        {
            mustlocktakeoff = true;
            while (mpanel7 < 150)
            {

                plane6.setPosition(19, mpanel7);
                Graphics graphics = panel7.CreateGraphics();

                //SolidBrush brush = new SolidBrush(Color.Black);
                Thread.Sleep(50);
                graphics.Clear(Color.DarkGray);
                graphics.DrawImage(new Bitmap("Pics/plane4.png"), plane6.getPositionX(), plane6.getPositionY(), 35, 35);
                //hub1.movePlane(mpanel11, hub1.getPositionY());
                if (mpanel7 >= 50)
                {

                    while (mustlockrunway == true) { }

                }
                graphics.Dispose();
                mpanel7 += 5;
            } mustlocktakeoff = false;



        }
        private void panel10_Paint(object sender, PaintEventArgs e)
        {
           
           // panel10.Invalidate();
        }

        private void Land_Click(object sender, EventArgs e)
        {
            startfunction0 = new Thread(signalone);
            startfunction0.Start();
            startfunction1 = new Thread(signaltwo);
            startfunction1.Start();
            startfunction2 = new Thread(signalthree);
            startfunction2.Start();
            startfunction3 = new Thread(signalfour);
            startfunction3.Start();
            
            
            
           
        }
        
        private void terminal1mth()
        {
            if (hub1.getlandinfo() == "1")
            {
                hub1.landing("2");
               
               

                movepanel11();
                if (hub1.getPositionY() >= 200)
                {
                    plane2.setdestination(null);
                    plane2.setdestination("2");
                    hub2.setdestination("3");
                    mpanel4 = 60;
                    mpanel41 = 0;
                    movepanel4();
                    mpanel41 = 0;
                    mpanel4 = 60;
                    if (plane3.getPositionX() >= 10)
                    {
                        plane6.setdestination(null);
                        plane6.setdestination("3");
                        hub3.setdestination("4");
                        mpanel5 = 0;
                        mpanel51 = 0;
                        movepanel5();
                        mpanel5 = 0;
                        mpanel51 = 0;
                        if (plane4.getPositionX() >= 10)
                        {
                            
                            plane4.setdestination("4");
                            mpanel6 = 0;
                            mpanel61 = 0;
                            movepanel6();
                            mpanel6 = 0;
                            mpanel61 = 0;
                            if (plane5.getPositionX() >= 50)
                            {
                                plane.setdestination("0");
                                mpanel7 = 0;
                                movepanel7();
                                mpanel7 = 0;
                                if (plane.getDestination() == "0")
                                {
                                    mpanel8 = 650;
                                    mpanel81 = 650;
                                    movepanel8();
                                    mpanel8 = 650;
                                    mpanel81 = 650;
                                }
                            }
                        }
                    }
                }
            }
        }
        private void terminal2mth()
        {
            if (hub2.getlandinfo() == "1")
            {
                hub2.landing("2");
               

                movepanel2();

                if (plane3.getPositionX() >= 10)
                {
                    plane6.setdestination(null);
                    plane6.setdestination("3");
                    hub3.setdestination("4");
                    mpanel5 = 0;
                    mpanel51 = 0;
                    movepanel5();
                    mpanel5 = 0;
                    mpanel51 = 0;
                    if (plane4.getPositionX() >= 10)
                    {
                        plane4.setdestination("4");
                       
                        mpanel6 = 0;
                        mpanel61 = 0;
                        movepanel6();
                        mpanel6 = 0;
                        mpanel61 = 0;
                        if (plane5.getPositionX() >= 50)
                        {
                            plane.setdestination("0");
                            mpanel7 = 0;
                            movepanel7();
                            mpanel7 = 0;
                            if (plane.getDestination() == "0")
                            {
                                mpanel8 = 650;
                                mpanel81 = 650;
                                movepanel8();
                                mpanel8 = 650;
                                mpanel81 = 650;
                            }
                        }
                    }
                }
            }
        }
        private void terminal3mth()
        {
            if (hub3.getlandinfo() == "1")
            {
                hub3.landing("2");
                
                movepanel3();


                if (plane4.getPositionX() >= 10)
                {
                    plane4.setdestination("4");
                    mpanel6 = 0;
                    mpanel61 = 0;
                    movepanel6();
                    mpanel6 = 0;
                    mpanel61 = 0;
                    if (plane5.getPositionX() >= 50)
                    {
                        plane.setdestination("0");
                        mpanel7 = 0;
                        movepanel7();
                        mpanel7 = 0;
                        if (plane.getDestination() == "0")
                        {
                            mpanel8 = 650;
                            mpanel81 = 650;
                            movepanel8();
                            mpanel8 = 650;
                            mpanel81 = 650;
                        }
                    }
                }

            }
        }
       
        private void teminal1_Click(object sender, EventArgs e)
        {
            terminal1th =new Thread(terminal1mth); ;
            terminal1th.Start();
        }

        private void terminal2_Click(object sender, EventArgs e)
        {
             terminal2th=new Thread(terminal2mth);
            terminal2th.Start();
        }

        private void terminal3_Click(object sender, EventArgs e)
        {
            terminal3th = new Thread(terminal3mth);
            terminal3th.Start();
        }
        private void signalone() {

            if (radioButton4.Checked)
            {
                plane.setdestination(radioButton4.Text);
                movepanel10();

                if (plane.getPositionX() <= -20)
                {
                    mpanel8 = 650;
                    mpanel81 = 650;
                    movepanel8();
                    mpanel8 = 650;
                    mpanel81 = 650;

                }
            }
        }
        private void signaltwo() {
            if (radioButton1.Checked)
            {
                plane.setdestination(radioButton1.Text);
                
               
                plane3.setdestination(radioButton1.Text);
                
                movepanel10();


                if (plane.getPositionX() <= -20)
                {
                    mpanel8 = 650;
                    movepanel8();
                    mpanel8 = 650;
                    if (plane1.getPositionX() <= 125)
                    {
                        hub1.setdestination("2");
                        mpanel9 = 45;
                        movepanel9();
                        mpanel9 = 45;
                        if (plane2.getPositionY() <= 0)
                        {
                            //plane2.setdestination(null);
                            plane2.setdestination("2");
                            hub2.setdestination("3");
                            mpanel4 = 60;
                            mpanel41 = 0;
                            movepanel4();
                            mpanel41 = 0;
                            mpanel4 = 60;
                            if (plane3.getPositionX() >= 10)
                            {
                                plane6.setdestination(null);
                                plane6.setdestination("3");
                                hub3.setdestination("3");
                                mpanel5 = 0;
                                mpanel51 = 0;
                                movepanel5();
                                mpanel5 = 0;
                                mpanel51 = 0;
                                if (plane4.getPositionX() >= 10)
                                {
                                    plane4.setdestination(null);
                                    plane4.setdestination("3");
                                    mpanel6 = 0;
                                    mpanel61 = 0;
                                    movepanel6();
                                    mpanel6 = 0;
                                    mpanel61 = 0;
                                    hub3.landing("1");
                                    if (plane5.getPositionY() >= -30)
                                    {
                                        mpanel3 = 120; 
                                        mpanel33 = 0;
                                        movepanel3();
                                        mpanel3 = 120;
                                        mpanel33 = 0;
                                    }
                                }
                            }

                        }
                    }

                }
            }
        }
        private void signalfour() {
            if (radioButton3.Checked)
            {
                plane.setdestination(radioButton3.Text);
                

                movepanel10();

                if (plane.getPositionX() <= -20)
                {
                    mpanel8 = 650;
                    movepanel8();
                    mpanel8 = 650;
                    if (plane1.getPositionX() <= 125)
                    {
                        hub1.setdestination("1");
                        mpanel9 = 45;
                        movepanel9();
                        mpanel9 = 45;
                        if (plane2.getPositionY() <= 0)
                        {
                            //plane3.setdestination(null);
                            plane3.setdestination("1");
                            mpanel4 = 60;
                            movepanel4();
                            mpanel4 = 60;
                            if (plane3.getPositionY() <= 0)
                            {
                                hub1.landing("1");
                                mpanel11 = 100;
                                mpanel111 = 100;
                                movepanel11();
                                mpanel111 = 100;
                                mpanel11 = 100;
                            }
                        }
                    }

                }

                // MessageBox.Show(radioButton4.Text);


            }
        }
        private void signalthree()
        {
            if (radioButton2.Checked)
            {
                plane.setdestination(radioButton2.Text);
                
                
                hub2.landing("1");
                movepanel10();


                if (plane.getPositionX() <= -20)
                {
                    mpanel8 = 650;
                    movepanel8();
                    mpanel8 = 650;
                    if (plane1.getPositionX() <= 125)
                    {
                        hub1.setdestination("2");
                        mpanel9 = 45;
                        movepanel9();
                        mpanel9 = 45;
                        if (plane2.getPositionY() <= 0)
                        {
                            //plane2.setdestination(null);
                            plane2.setdestination("2");
                            hub2.setdestination("2");
                            mpanel4 = 60;
                            mpanel41 = 0;
                            movepanel4();
                            mpanel41 = 0;
                            mpanel4 = 60;
                            if (plane3.getPositionX() >= 10)
                            {
                                plane6.setdestination(null);
                                plane6.setdestination("2");
                                mpanel5 = 0;
                                mpanel51 = 0;
                                movepanel5();
                                mpanel5 = 0;
                                mpanel51 = 0;
                                if (plane4.getPositionY() >= -30)
                                {
                                    mpanel2 = 100; 
                                    mpanel22 = 0;
                                    movepanel2();
                                    mpanel2 = 100;
                                    mpanel22 = 0;
                                }
                            }

                        }
                    }

                }

                // MessageBox.Show(radioButton4.Text);


            }
        }

    }
}
