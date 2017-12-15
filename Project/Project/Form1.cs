using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void hid1() //method ซ่อนปุ่มจองคอมพิวเตอร์เครื่องแรก
        {
            button17.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 1 2 ชั่วโมง
            button18.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 1 1 ชั่วโมง 30 นาที
            button19.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 1 1 ชั่วโมง
            button20.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 1 30 นาที
            button81.Visible = false;//ซ่อนปุ่มยกเลิกการจองเครื่อง
            label4.Visible = false;//ซ่อนเลขเครื่อง
            label3.Visible = false;//ซ่อนข้อความ
        }
        private void hid2() //method ซ่อนปุ่มจองคอมพิวเตอร์เครื่องที่ 2
        {
            button21.Visible = false;// ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 2 2 ชั่วโมง 
            button22.Visible = false;// ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 2 1 ชั่วโมง 30 นาที
            button23.Visible = false;// ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 2 1 ชั่วโมง
            button24.Visible = false;// ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 2 30 นาที
            button81.Visible = false;//ซ่อนปุ่มยกเลิกการจองเครื่อง
            label4.Visible = false;//ซ่อนเลขเครื่อง
            label3.Visible = false;//ซ่อนข้อความ
        }
        private void hid3()//method ซ่อนปุ่มจองคอมพิวเตอร์เครื่องที่ 3
        {
            button25.Visible = false; //ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 3 30 นาที
            button26.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 3 1 ชั่วโมง
            button27.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 3 1 ชั่วโมง30 นาที
            button28.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 3 2 ชั่วโมง
            button81.Visible = false;//ซ่อนปุ่มยกเลิกการจองเครื่อง
            label4.Visible = false;//ซ่อนเลขเครื่อง
            label3.Visible = false;//ซ่อนข้อความ
        }
        private void hid4()//method ซ่อนปุ่มจองคอมพิวเตอร์เครื่องที่ 4
        {
            button29.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 4 30 นาที
            button30.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 4 1 ชั่วโมง 
            button31.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 4 1 ชั่วโมง 30 นาที 
            button32.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 4 2 ชั่วโมง 
            button81.Visible = false;//ซ่อนปุ่มยกเลิกการจองเครื่อง
            label4.Visible = false;//ซ่อนเลขเครื่อง
            label3.Visible = false;//ซ่อนข้อความ
        }
        private void hid5()//method ซ่อนปุ่มจองคอมพิวเตอร์เครื่องที่ 5
        {
            button33.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 5 30 นาที
            button34.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 5 1 ชั่วโมง 
            button35.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 5 1 ชั่วโมง 30 นาที
            button36.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 5 2 ชั่วโมง
            button81.Visible = false;//ซ่อนปุ่มยกเลิกการจองเครื่อง
            label4.Visible = false;//ซ่อนเลขเครื่อง
            label3.Visible = false;//ซ่อนข้อความ
        }
        private void hid6()//method ซ่อนปุ่มจองคอมพิวเตอร์เครื่องที่ 6
        {
            button37.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 6 30 นาที
            button38.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 6 1 ชั่วโมง 
            button39.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 6 1 ชั่วโมง 30 นาที
            button40.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 6 2 ชั่วโมง
            button81.Visible = false;//ซ่อนปุ่มยกเลิกการจองเครื่อง
            label4.Visible = false;//ซ่อนเลขเครื่อง
            label3.Visible = false;//ซ่อนข้อความ
        }
        private void hid7()//method ซ่อนปุ่มจองคอมพิวเตอร์เครื่องที่ 7
        {
            button41.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 7 30 นาที
            button42.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 7 1 ชั่วโมง 
            button43.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 7 1 ชั่วโมง 30 นาที
            button44.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 7 2 ชั่วโมง
            button81.Visible = false;//ซ่อนปุ่มยกเลิกการจองเครื่อง
            label4.Visible = false;//ซ่อนเลขเครื่อง
            label3.Visible = false;//ซ่อนข้อความ
        }
        private void hid8()//method ซ่อนปุ่มจองคอมพิวเตอร์เครื่องที่ 8
        {
            button45.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 8 30 นาที
            button46.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 8 1 ชั่วโมง 
            button47.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 8 1 ชั่วโมง 30 นาที
            button48.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 8 2 ชั่วโมง
            button81.Visible = false;//ซ่อนปุ่มยกเลิกการจองเครื่อง
            label4.Visible = false;//ซ่อนเลขเครื่อง
            label3.Visible = false;//ซ่อนข้อความ
        }
        private void hid9()//method ซ่อนปุ่มจองคอมพิวเตอร์เครื่องที่ 9
        {
            button49.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 9 30 นาที
            button50.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 9 1 ชั่วโมง 
            button51.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 9 1 ชั่วโมง 30 นาที
            button52.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 9 2 ชั่วโมง
            button81.Visible = false;//ซ่อนปุ่มยกเลิกการจองเครื่อง
            label4.Visible = false;//ซ่อนเลขเครื่อง
            label3.Visible = false;//ซ่อนข้อความ
        }
        private void hid10()//method ซ่อนปุ่มจองคอมพิวเตอร์เครื่องที่ 10
        {
            button53.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 10 30 นาที
            button54.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 10 1 ชั่วโมง 
            button55.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 10 1 ชั่วโมง 30 นาที
            button56.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 10 2 ชั่วโมง
            button81.Visible = false;//ซ่อนปุ่มยกเลิกการจองเครื่อง
            label4.Visible = false;//ซ่อนเลขเครื่อง
            label3.Visible = false;//ซ่อนข้อความ
        }
        private void hid11()//method ซ่อนปุ่มจองคอมพิวเตอร์เครื่องที่ 11
        {
            button57.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 11 30 นาที
            button58.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 11 1 ชั่วโมง 
            button59.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 11 1 ชั่วโมง 30 นาที
            button60.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 11 2 ชั่วโมง
            button81.Visible = false;//ซ่อนปุ่มยกเลิกการจองเครื่อง
            label4.Visible = false;//ซ่อนเลขเครื่อง
            label3.Visible = false;//ซ่อนข้อความ
        }
        private void hid12()//method ซ่อนปุ่มจองคอมพิวเตอร์เครื่องที่ 12
        {
            button61.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 12 30 นาที
            button62.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 12 1 ชั่วโมง 
            button63.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 12 1 ชั่วโมง 30 นาที
            button64.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 12 2 ชั่วโมง
            button81.Visible = false;//ซ่อนปุ่มยกเลิกการจองเครื่อง
            label4.Visible = false;//ซ่อนเลขเครื่อง
            label3.Visible = false;//ซ่อนข้อความ
        }
        private void hid13()//method ซ่อนปุ่มจองคอมพิวเตอร์เครื่องที่ 13
        {
            button65.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 13 30 นาที
            button66.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 13 1 ชั่วโมง 
            button67.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 13 1 ชั่วโมง 30 นาที
            button68.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 13 2 ชั่วโมง
            button81.Visible = false;//ซ่อนปุ่มยกเลิกการจองเครื่อง
            label4.Visible = false;//ซ่อนเลขเครื่อง
            label3.Visible = false;//ซ่อนข้อความ
        }
        private void hid14()//method ซ่อนปุ่มจองคอมพิวเตอร์เครื่องที่ 14
        {
            button69.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 14 30 นาที
            button70.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 14 1 ชั่วโมง 
            button71.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 14 1 ชั่วโมง 30 นาที
            button72.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 14 2 ชั่วโมง
            button81.Visible = false;//ซ่อนปุ่มยกเลิกการจองเครื่อง
            label4.Visible = false;//ซ่อนเลขเครื่อง
            label3.Visible = false;//ซ่อนข้อความ
        }
        private void hid15()//method ซ่อนปุ่มจองคอมพิวเตอร์เครื่องที่ 15
        {
            button73.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 15 30 นาที
            button74.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 15 1 ชั่วโมง 
            button75.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 15 1 ชั่วโมง 30 นาที    
            button76.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 15 2 ชั่วโมง
            button81.Visible = false;//ซ่อนปุ่มยกเลิกการจองเครื่อง
            label4.Visible = false;//ซ่อนเลขเครื่อง
            label3.Visible = false;//ซ่อนข้อความ
        }
        private void hid16()//method ซ่อนปุ่มจองคอมพิวเตอร์เครื่องที่ 16
        {
            button77.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 16 30 นาที
            button78.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 16 1 ชั่วโมง 
            button79.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 16 1 ชั่วโมง 30 นาที    
            button80.Visible = false;//ซ่อนปุ่มจองเครื่องคอมพิวเตอร์ที 16 2 ชั่วโมง
            button81.Visible = false;//ซ่อนปุ่มยกเลิกการจองเครื่อง
            label4.Visible = false;//ซ่อนเลขเครื่อง
            label3.Visible = false;//ซ่อนข้อความ
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString(); //แสดงเวลาปัจจุบันใน label
            label2.Text = DateTime.Now.ToLongDateString(); //แสดงวันเดือนปีปัจจุบันใน label
            hid1();hid2();hid3();hid4(); 
            hid5();hid6();hid7();hid8();
            hid9();hid10();hid11();hid12();
            hid13();hid14();hid15();hid16(); //ซ่อนทุกๆปุ่มเมื่อเริ่มโปรแกรม            
        }
      

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString(); //แสดงเวลาปัจจุบันใน label
            label2.Text = DateTime.Now.ToLongDateString(); //แสดงวันเดือนปีปัจจุบันใน label  
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            button17.Visible = true; //แสดงปุ่มจองเครื่องคอมพิวเตอร์ที 1 2 ชั่วโมง
            button18.Visible = true;//แสดงปุ่มจองเครื่องคอมพิวเตอร์ที 1 1 ชั่วโมง 30 นาที
            button19.Visible = true;//แสดงปุ่มจองเครื่องคอมพิวเตอร์ที 1 1 ชั่วโมง
            button20.Visible = true;//แสดงปุ่มจองเครื่องคอมพิวเตอร์ที 1 30 นาที
            hid2(); hid3(); hid4();
            hid5(); hid6(); hid7(); hid8();
            hid9(); hid10(); hid11(); hid12();
            hid13(); hid14(); hid15(); hid16(); //ซ่อนปุ่มทุกๆปุ่มนอกจากปุ่มจองของคอมพิวเตอร์เครื่องที่ 1
            button81.Visible = true; //แสดงปุ่มยกเลิกการจองเครื่องคอมพิวเดอร์
            label4.Text = "1"; 
            label4.Visible = true;  
            label3.Visible = true; //แสดงข้อความคอมพิวเตอร์เครื่องที่ 1
        }

        private void button21_Click(object sender, EventArgs e)
        {
            hid2(); //ซ่อนปุ่มจองเครื่องที่ 2
            timer3.Interval = 7200000; //กำหนดเวลา 2 ชั่วโมง(1000=1วินาที)
            timer3.Tick += timer3_Tick; //นับเวลาจาก timer 3
            timer3.Start(); //เริ่มนับเมื่อกดปุ่ม
            button2.Enabled = false; //เครื่องที่2จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button22_Click(object sender, EventArgs e)
        {
            hid2();//ซ่อนปุ่มจองเครื่องที่ 2
            timer3.Interval = 5400000;//กำหนดเวลา 1 ชั่วโมง 30 นาที(1000=1วินาที)
            timer3.Tick += timer3_Tick;//นับเวลาจาก timer 3
            timer3.Start();//เริ่มนับเมื่อกดปุ่ม
            button2.Enabled = false;//เครื่องที่2จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button23_Click(object sender, EventArgs e)
        {
            hid2();//ซ่อนปุ่มจองเครื่องที่ 2
            timer3.Interval = 3600000;//กำหนดเวลา 1 ชั่วโมง(1000=1วินาที)
            timer3.Tick += timer3_Tick;//นับเวลาจาก timer 3
            timer3.Start();//เริ่มนับเมื่อกดปุ่ม
            button2.Enabled = false;//เครื่องที่2จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button24_Click(object sender, EventArgs e)
        {
            hid2();//ซ่อนปุ่มจองเครื่องที่ 2
            timer3.Interval = 1800000;//กำหนดเวลา 30 นาที(1000=1วินาที)
            timer3.Tick += timer3_Tick;//นับเวลาจาก timer 3
            timer3.Start();//เริ่มนับเมื่อกดปุ่ม
            button2.Enabled = false;//เครื่องที่2จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button20_Click(object sender, EventArgs e)
        {
            hid1();//ซ่อนปุ่มจองเครื่องที่ 1
            timer2.Interval = 1800000;//กำหนดเวลา 30 นาที(1000=1วินาที)
            timer2.Tick += timer2_Tick;//นับเวลาจาก timer 2
            timer2.Start();//เริ่มนับเมื่อกดปุ่ม
            button1.Enabled = false;//เครื่องที่2จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button19_Click(object sender, EventArgs e)
        {
            hid1();//ซ่อนปุ่มจองเครื่องที่ 1
            timer2.Interval = 3600000;//กำหนดเวลา 1 ชั่วโมง(1000=1วินาที)
            timer2.Tick += timer2_Tick;//นับเวลาจาก timer 2
            timer2.Start();//เริ่มนับเมื่อกดปุ่ม
            button1.Enabled = false;//เครื่องที่2จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button18_Click(object sender, EventArgs e)
        {
            hid1();//ซ่อนปุ่มจองเครื่องที่ 1
            timer2.Interval = 5400000;//กำหนดเวลา 1 ชั่วโมง 30 นาที(1000=1วินาที)
            timer2.Tick += timer2_Tick;//นับเวลาจาก timer 2
            timer2.Start();//เริ่มนับเมื่อกดปุ่ม
            button1.Enabled = false;//เครื่องที่2จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button17_Click(object sender, EventArgs e)
        {
            hid1();//ซ่อนปุ่มจองเครื่องที่ 1   
            timer2.Interval = 7200000;//กำหนดเวลา 2 ชั่วโมง(1000=1วินาที)
            timer2.Tick += timer2_Tick;//นับเวลาจาก timer 2
            timer2.Start();//เริ่มนับเมื่อกดปุ่ม
            button1.Enabled = false;//เครื่องที่2จะจองไม่ได้จนกว่าจะหมดเวลา

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            button1.Enabled = true;  //เปิดให้จองเครื่องที่ 1          
        }

        private void button2_Click(object sender, EventArgs e) //คอมพิวเตอร์เครื่องที่ 2
        {           
            button21.Visible = true;//แสดงปุ่มจอง 2 ชั่วโมง
            button22.Visible = true;//แสดงปุ่มจอง 1 ชั่วโมง 30 นาที
            button23.Visible = true;//แสดงปุ่มจอง 1 ชั่วโมง
            button24.Visible = true;//แสดงปุ่มจอง 30 นาที
            hid1(); hid3(); hid4();
            hid5(); hid6(); hid7(); hid8();
            hid9(); hid10(); hid11(); hid12();
            hid13(); hid14(); hid15(); hid16(); //ซ่อนทุกปุ่มยกเว้นปุ่มจองของเครื่องที่ 2
            button81.Visible = true; //แสดงปุ่มยกเลิกการจองเครื่องคอมพิวเดอร์
            label4.Text = "2";
            label4.Visible = true;
            label3.Visible = true; //แสดงข้อความคอมพิวเตอร์เครื่องที่ 2
        }

        private void button25_Click(object sender, EventArgs e)
        {
            hid3();//ซ่อนปุ่มจองเครื่องที่ 3   
            timer4.Interval = 1800000;//กำหนดเวลา 30 นาที(1000=1วินาที)
            timer4.Tick += timer4_Tick;//นับเวลาจาก timer 4
            timer4.Start();//เริ่มนับเมื่อกดปุ่ม
            button3.Enabled = false;//เครื่องที่3จะจองไม่ได้จนกว่าจะหมดเวลา

        }

        private void button26_Click(object sender, EventArgs e)
        {
            hid3();//ซ่อนปุ่มจองเครื่องที่ 3 
            timer4.Interval = 3600000;//กำหนดเวลา 1ชั่วโมง(1000=1วินาที)
            timer4.Tick += timer4_Tick;//นับเวลาจาก timer 4
            timer4.Start();//เริ่มนับเมื่อกดปุ่ม
            button3.Enabled = false;//เครื่องที่3จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button27_Click(object sender, EventArgs e)
        {
            hid3();//ซ่อนปุ่มจองเครื่องที่ 3 
            timer4.Interval = 5400000;//กำหนดเวลา 1ชั่วโมง30นาที(1000=1วินาที)
            timer4.Tick += timer4_Tick;//นับเวลาจาก timer 4
            timer4.Start();//เริ่มนับเมื่อกดปุ่ม
            button3.Enabled = false;//เครื่องที่3จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button28_Click(object sender, EventArgs e)
        {
            hid3();//ซ่อนปุ่มจองเครื่องที่ 3 
            timer4.Interval = 7200000;//กำหนดเวลา 2ชั่วโมง(1000=1วินาที)
            timer4.Tick += timer4_Tick;//นับเวลาจาก timer 4
            timer4.Start();//เริ่มนับเมื่อกดปุ่ม
            button3.Enabled = false;//เครื่องที่3จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button3_Click(object sender, EventArgs e)//คอมพิวเตอร์เครื่องที่ 3
        {    
            button25.Visible = true;//แสดงปุ่มจอง 30 นาที
            button26.Visible = true;//แสดงปุ่มจอง 1 ชั่วโมง 
            button27.Visible = true;//แสดงปุ่มจอง 1 ชั่วโมง 30 นาที
            button28.Visible = true;//แสดงปุ่มจอง 2ชั่วโมง
            hid1(); hid2(); hid4();
            hid5(); hid6(); hid7(); hid8();
            hid9(); hid10(); hid11(); hid12();
            hid13(); hid14(); hid15(); hid16();//ซ่อนทุกปุ่มยกเว้นปุ่มจองของเครื่องที่ 3
            button81.Visible = true;//แสดงปุ่มยกเลิกการจองเครื่องคอมพิวเดอร์
            label4.Text = "3";
            label4.Visible = true;
            label3.Visible = true;//แสดงข้อความคอมพิวเตอร์เครื่องที่ 3
        }

        private void button4_Click(object sender, EventArgs e)//คอมพิวเตอร์เครื่องที่ 4
        {
            button29.Visible = true;//แสดงปุ่มจอง 30 นาที
            button30.Visible = true;//แสดงปุ่มจอง 1 ชั่วโมง
            button31.Visible = true;//แสดงปุ่มจอง 1 ชั่วโมง 30 นาที
            button32.Visible = true;//แสดงปุ่มจอง 2ชั่วโมง
            hid1(); hid2(); hid3(); 
            hid5(); hid6(); hid7(); hid8();
            hid9(); hid10(); hid11(); hid12();
            hid13(); hid14(); hid15(); hid16();//ซ่อนทุกปุ่มยกเว้นปุ่มจองของเครื่องที่ 4
            button81.Visible = true;//แสดงปุ่มยกเลิกการจองเครื่องคอมพิวเดอร์
            label4.Text = "4";
            label4.Visible = true;
            label3.Visible = true;//แสดงข้อความคอมพิวเตอร์เครื่องที่ 4
        }

        private void button5_Click(object sender, EventArgs e)//คอมพิวเตอร์เครื่องที่ 5
        {
            button33.Visible = true;//แสดงปุ่มจอง 30 นาที
            button34.Visible = true;//แสดงปุ่มจอง 1 ชั่วโมง
            button35.Visible = true;//แสดงปุ่มจอง 1 ชั่วโมง 30 นาที
            button36.Visible = true;//แสดงปุ่มจอง 2ชั่วโมง
            hid1(); hid2(); hid3(); hid4();
            hid6(); hid7(); hid8();
            hid9(); hid10(); hid11(); hid12();
            hid13(); hid14(); hid15(); hid16();//ซ่อนทุกปุ่มยกเว้นปุ่มจองของเครื่องที่ 5
            button81.Visible = true;//แสดงปุ่มยกเลิกการจองเครื่องคอมพิวเดอร์
            label4.Text = "5";
            label4.Visible = true;
            label3.Visible = true;//แสดงข้อความคอมพิวเตอร์เครื่องที่ 5
        }

        private void button6_Click(object sender, EventArgs e)//คอมพิวเตอร์เครื่องที่ 6
        {
            button37.Visible = true;//แสดงปุ่มจอง 30 นาที
            button38.Visible = true;//แสดงปุ่มจอง 1 ชั่วโมง
            button39.Visible = true;//แสดงปุ่มจอง 1 ชั่วโมง 30 นาที
            button40.Visible = true;//แสดงปุ่มจอง 2ชั่วโมง
            hid1(); hid2(); hid3(); hid4();
            hid5(); hid7(); hid8();
            hid9(); hid10(); hid11(); hid12();
            hid13(); hid14(); hid15(); hid16();//ซ่อนทุกปุ่มยกเว้นปุ่มจองของเครื่องที่ 6
            button81.Visible = true;//แสดงปุ่มยกเลิกการจองเครื่องคอมพิวเดอร์
            label4.Text = "6";
            label4.Visible = true;
            label3.Visible = true;//แสดงข้อความคอมพิวเตอร์เครื่องที่ 6
        }

        private void button7_Click(object sender, EventArgs e)//คอมพิวเตอร์เครื่องที่ 7
        {
            button41.Visible = true;//แสดงปุ่มจอง 30 นาที
            button42.Visible = true;//แสดงปุ่มจอง 1 ชั่วโมง
            button43.Visible = true;//แสดงปุ่มจอง 1 ชั่วโมง 30 นาที
            button44.Visible = true;//แสดงปุ่มจอง 2ชั่วโมง
            hid1(); hid2(); hid3(); hid4();
            hid5(); hid6(); hid8();
            hid9(); hid10(); hid11(); hid12();
            hid13(); hid14(); hid15(); hid16();//ซ่อนทุกปุ่มยกเว้นปุ่มจองของเครื่องที่ 7
            button81.Visible = true;//แสดงปุ่มยกเลิกการจองเครื่องคอมพิวเดอร์
            label4.Text = "7";
            label4.Visible = true;
            label3.Visible = true;//แสดงข้อความคอมพิวเตอร์เครื่องที่ 7
        }

        private void button8_Click(object sender, EventArgs e)//คอมพิวเตอร์เครื่องที่ 8
        {
            button45.Visible = true;//แสดงปุ่มจอง 30 นาที
            button46.Visible = true;//แสดงปุ่มจอง 1 ชั่วโมง
            button47.Visible = true;//แสดงปุ่มจอง 1 ชั่วโมง 30 นาที
            button48.Visible = true;//แสดงปุ่มจอง 2ชั่วโมง
            hid1(); hid2(); hid3(); hid4();
            hid5(); hid6(); hid7();
            hid9(); hid10(); hid11(); hid12();
            hid13(); hid14(); hid15(); hid16();//ซ่อนทุกปุ่มยกเว้นปุ่มจองของเครื่องที่ 8
            button81.Visible = true;//แสดงปุ่มยกเลิกการจองเครื่องคอมพิวเดอร์
            label4.Text = "8";
            label4.Visible = true;
            label3.Visible = true;//แสดงข้อความคอมพิวเตอร์เครื่องที่ 8
        }

        private void button9_Click(object sender, EventArgs e)//คอมพิวเตอร์เครื่องที่ 9
        {
            button49.Visible = true;//แสดงปุ่มจอง 30 นาที
            button50.Visible = true;//แสดงปุ่มจอง 1 ชั่วโมง
            button51.Visible = true;//แสดงปุ่มจอง 1 ชั่วโมง 30 นาที
            button52.Visible = true;//แสดงปุ่มจอง 2ชั่วโมง
            hid1(); hid2(); hid3(); hid4();
            hid5(); hid6(); hid7(); hid8();
            hid10(); hid11(); hid12();
            hid13(); hid14(); hid15(); hid16();//ซ่อนทุกปุ่มยกเว้นปุ่มจองของเครื่องที่ 9
            button81.Visible = true;//แสดงปุ่มยกเลิกการจองเครื่องคอมพิวเดอร์
            label4.Text = "9";
            label4.Visible = true;
            label3.Visible = true;//แสดงข้อความคอมพิวเตอร์เครื่องที่ 9
        }

        private void button10_Click(object sender, EventArgs e)//คอมพิวเตอร์เครื่องที่ 10
        {
            button53.Visible = true;//แสดงปุ่มจอง 30 นาที
            button54.Visible = true;//แสดงปุ่มจอง 1 ชั่วโมง
            button55.Visible = true;//แสดงปุ่มจอง 1 ชั่วโมง 30 นาที
            button56.Visible = true;//แสดงปุ่มจอง 2ชั่วโมง
            hid1(); hid2(); hid3(); hid4();
            hid5(); hid6(); hid7(); hid8();
            hid9(); hid11(); hid12();
            hid13(); hid14(); hid15(); hid16();//ซ่อนทุกปุ่มยกเว้นปุ่มจองของเครื่องที่ 10
            button81.Visible = true;//แสดงปุ่มยกเลิกการจองเครื่องคอมพิวเดอร์
            label4.Text = "10";
            label4.Visible = true;
            label3.Visible = true;//แสดงข้อความคอมพิวเตอร์เครื่องที่ 10
        }

        private void button11_Click(object sender, EventArgs e)//คอมพิวเตอร์เครื่องที่ 11
        {
            button57.Visible = true;//แสดงปุ่มจอง 30 นาที
            button58.Visible = true;//แสดงปุ่มจอง 1 ชั่วโมง
            button59.Visible = true;//แสดงปุ่มจอง 1 ชั่วโมง 30 นาที
            button60.Visible = true;//แสดงปุ่มจอง 2ชั่วโมง
            hid1(); hid2(); hid3(); hid4();
            hid5(); hid6(); hid7(); hid8();
            hid9(); hid10(); hid12();
            hid13(); hid14(); hid15(); hid16();//ซ่อนทุกปุ่มยกเว้นปุ่มจองของเครื่องที่ 11
            button81.Visible = true;//แสดงปุ่มยกเลิกการจองเครื่องคอมพิวเดอร์
            label4.Text = "11";
            label4.Visible = true;
            label3.Visible = true;//แสดงข้อความคอมพิวเตอร์เครื่องที่ 11
        }

        private void button12_Click(object sender, EventArgs e)//คอมพิวเตอร์เครื่องที่ 12
        {
            button61.Visible = true;//แสดงปุ่มจอง 30 นาที
            button62.Visible = true;//แสดงปุ่มจอง 1 ชั่วโมง
            button63.Visible = true;//แสดงปุ่มจอง 1 ชั่วโมง 30 นาที
            button64.Visible = true;//แสดงปุ่มจอง 2ชั่วโมง
            hid1(); hid2(); hid3(); hid4();
            hid5(); hid6(); hid7(); hid8();
            hid9(); hid10(); hid11();
            hid13(); hid14(); hid15(); hid16();//ซ่อนทุกปุ่มยกเว้นปุ่มจองของเครื่องที่ 12
            button81.Visible = true;//แสดงปุ่มยกเลิกการจองเครื่องคอมพิวเดอร์
            label4.Text = "12";
            label4.Visible = true;
            label3.Visible = true;//แสดงข้อความคอมพิวเตอร์เครื่องที่ 12
        }

        private void button13_Click(object sender, EventArgs e)//คอมพิวเตอร์เครื่องที่ 13
        {
            button65.Visible = true;//แสดงปุ่มจอง 30 นาที
            button66.Visible = true;//แสดงปุ่มจอง 1 ชั่วโมง
            button67.Visible = true;//แสดงปุ่มจอง 1 ชั่วโมง 30 นาที
            button68.Visible = true;//แสดงปุ่มจอง 2ชั่วโมง
            hid1(); hid2(); hid3(); hid4();
            hid5(); hid6(); hid7(); hid8();
            hid9(); hid10(); hid11(); hid12();
            hid14(); hid15(); hid16();//ซ่อนทุกปุ่มยกเว้นปุ่มจองของเครื่องที่ 13
            button81.Visible = true;//แสดงปุ่มยกเลิกการจองเครื่องคอมพิวเดอร์
            label4.Text = "13";
            label4.Visible = true;
            label3.Visible = true;//แสดงข้อความคอมพิวเตอร์เครื่องที่ 13
        }

        private void button14_Click(object sender, EventArgs e)//คอมพิวเตอร์เครื่องที่ 14
        {
            button69.Visible = true;//แสดงปุ่มจอง 30 นาที
            button70.Visible = true;//แสดงปุ่มจอง 1 ชั่วโมง
            button71.Visible = true;//แสดงปุ่มจอง 1 ชั่วโมง 30 นาที
            button72.Visible = true;//แสดงปุ่มจอง 2ชั่วโมง
            hid1(); hid2(); hid3(); hid4();
            hid5(); hid6(); hid7(); hid8();
            hid9(); hid10(); hid11(); hid12();
            hid13(); hid15(); hid16();//ซ่อนทุกปุ่มยกเว้นปุ่มจองของเครื่องที่ 14
            button81.Visible = true;//แสดงปุ่มยกเลิกการจองเครื่องคอมพิวเดอร์
            label4.Text = "14";
            label4.Visible = true;
            label3.Visible = true;//แสดงข้อความคอมพิวเตอร์เครื่องที่ 14
        }

        private void button15_Click(object sender, EventArgs e)//คอมพิวเตอร์เครื่องที่ 15
        {
            button73.Visible = true;//แสดงปุ่มจอง 30 นาที
            button74.Visible = true;//แสดงปุ่มจอง 1 ชั่วโมง
            button75.Visible = true;//แสดงปุ่มจอง 1 ชั่วโมง 30 นาที
            button76.Visible = true;//แสดงปุ่มจอง 2ชั่วโมง
            hid1(); hid2(); hid3(); hid4();
            hid5(); hid6(); hid7(); hid8();
            hid9(); hid10(); hid11(); hid12();
            hid13(); hid14(); hid16();//ซ่อนทุกปุ่มยกเว้นปุ่มจองของเครื่องที่ 15
            button81.Visible = true;//แสดงปุ่มยกเลิกการจองเครื่องคอมพิวเดอร์
            label4.Text = "15";
            label4.Visible = true;
            label3.Visible = true;//แสดงข้อความคอมพิวเตอร์เครื่องที่ 15
        }

        private void button16_Click(object sender, EventArgs e)//คอมพิวเตอร์เครื่องที่ 16
        {
            button77.Visible = true;//แสดงปุ่มจอง 30 นาที
            button78.Visible = true;//แสดงปุ่มจอง 1 ชั่วโมง
            button79.Visible = true;//แสดงปุ่มจอง 1 ชั่วโมง 30 นาที
            button80.Visible = true;//แสดงปุ่มจอง 2ชั่วโมง
            hid1(); hid2(); hid3(); hid4();
            hid5(); hid6(); hid7(); hid8();
            hid9(); hid10(); hid11(); hid12();
            hid13(); hid14(); hid15();//ซ่อนทุกปุ่มยกเว้นปุ่มจองของเครื่องที่ 16
            button81.Visible = true;//แสดงปุ่มยกเลิกการจองเครื่องคอมพิวเดอร์
            label4.Text = "16";
            label4.Visible = true;
            label3.Visible = true;//แสดงข้อความคอมพิวเตอร์เครื่องที่ 16
        }

        private void button29_Click(object sender, EventArgs e)
        {
            hid4();//ซ่อนปุ่มจองเครื่องที่ 4  
            timer5.Interval = 1800000; //กำหนดเวลา30นาที(1000=1วินาที)
            timer5.Tick += timer5_Tick;//นับเวลาจาก timer 5
            timer5.Start();//เริ่มนับเมื่อกดปุ่ม
            button4.Enabled = false;//เครื่องที่4จะจองไม่ได้จนกว่าจะหมดเวลา            
        }

        private void button30_Click(object sender, EventArgs e)
        {
            hid4();//ซ่อนปุ่มจองเครื่องที่ 4
            timer5.Interval = 3600000;//กำหนดเวลา1 ชั่วโมง(1000=1วินาที)
            timer5.Tick += timer5_Tick;//นับเวลาจาก timer 5
            timer5.Start();//เริ่มนับเมื่อกดปุ่ม
            button4.Enabled = false;//เครื่องที่4จะจองไม่ได้จนกว่าจะหมดเวลา    
        }

        private void button31_Click(object sender, EventArgs e)
        {
            hid4();//ซ่อนปุ่มจองเครื่องที่ 4
            timer5.Interval = 5400000;//กำหนดเวลา1 ชั่วโมง 30 นาที(1000=1วินาที)
            timer5.Tick += timer5_Tick;//นับเวลาจาก timer 5
            timer5.Start();//เริ่มนับเมื่อกดปุ่ม
            button4.Enabled = false;//เครื่องที่4จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button32_Click(object sender, EventArgs e)
        {
            hid4();//ซ่อนปุ่มจองเครื่องที่ 4
            timer5.Interval = 7200000;//กำหนดเวลา2 ชั่วโมง(1000=1วินาที)
            timer5.Tick += timer5_Tick;//นับเวลาจาก timer 5
            timer5.Start();//เริ่มนับเมื่อกดปุ่ม
            button4.Enabled = false;//เครื่องที่4จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button33_Click(object sender, EventArgs e)
        {
            hid5();//ซ่อนปุ่มจองเครื่องที่ 5
            timer6.Interval = 1800000;//กำหนดเวลา30นาที(1000=1วินาที)
            timer6.Tick += timer6_Tick;//นับเวลาจาก timer 6
            timer6.Start();//เริ่มนับเมื่อกดปุ่ม
            button5.Enabled = false;//เครื่องที่จ5ะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button34_Click(object sender, EventArgs e)
        {
            hid5();//ซ่อนปุ่มจองเครื่องที่ 5
            timer6.Interval = 3600000;//กำหนดเวลา1 ชั่วโมง(1000=1วินาที)
            timer6.Tick += timer6_Tick;//นับเวลาจาก timer 6
            timer6.Start();//เริ่มนับเมื่อกดปุ่ม
            button5.Enabled = false;//เครื่องที่5จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button35_Click(object sender, EventArgs e)
        {
            hid5();//ซ่อนปุ่มจองเครื่องที่ 5
            timer6.Interval = 5400000;//กำหนดเวลา1 ชั่วโมง 30 นาที(1000=1วินาที)
            timer6.Tick += timer6_Tick;//นับเวลาจาก timer 6
            timer6.Start();//เริ่มนับเมื่อกดปุ่ม
            button5.Enabled = false;//เครื่องที่5จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button36_Click(object sender, EventArgs e)
        {
            hid5();//ซ่อนปุ่มจองเครื่องที่ 5
            timer6.Interval = 7200000;//กำหนดเวลา2 ชั่วโมง(1000=1วินาที)
            timer6.Tick += timer6_Tick;//นับเวลาจาก timer 6
            timer6.Start();//เริ่มนับเมื่อกดปุ่ม
            button5.Enabled = false;//เครื่องที่5จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button37_Click(object sender, EventArgs e)
        {
            hid6();//ซ่อนปุ่มจองเครื่องที่ 6
            timer7.Interval = 1800000;//กำหนดเวลา30นาที(1000=1วินาที)
            timer7.Tick += timer7_Tick;//นับเวลาจาก timer 7
            timer7.Start();//เริ่มนับเมื่อกดปุ่ม
            button6.Enabled = false;//เครื่องที่6จะจองไม่ได้จนกว่าจะหมดเวลา

        }

        private void button38_Click(object sender, EventArgs e)
        {
            hid6();//ซ่อนปุ่มจองเครื่องที่ 6
            timer7.Interval = 3600000;//กำหนดเวลา1 ชั่วโมง(1000=1วินาที)
            timer7.Tick += timer7_Tick;//นับเวลาจาก timer 7
            timer7.Start();//เริ่มนับเมื่อกดปุ่ม
            button6.Enabled = false;//เครื่องที่6จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button39_Click(object sender, EventArgs e)
        {
            hid6();//ซ่อนปุ่มจองเครื่องที่ 6
            timer7.Interval = 5400000;//กำหนดเวลา1 ชั่วโมง 30 นาที(1000=1วินาที)
            timer7.Tick += timer7_Tick;//นับเวลาจาก timer 7
            timer7.Start();//เริ่มนับเมื่อกดปุ่ม
            button6.Enabled = false;//เครื่องที่6จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button40_Click(object sender, EventArgs e)
        {
            hid6();//ซ่อนปุ่มจองเครื่องที่ 6
            timer7.Interval = 7200000;//กำหนดเวลา2 ชั่วโมง(1000=1วินาที)
            timer7.Tick += timer7_Tick;//นับเวลาจาก timer 7
            timer7.Start();//เริ่มนับเมื่อกดปุ่ม
            button6.Enabled = false;//เครื่องที่6จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button41_Click(object sender, EventArgs e)
        {
            hid7();//ซ่อนปุ่มจองเครื่องที่ 7
            timer8.Interval = 1800000;//กำหนดเวลา30นาที(1000=1วินาที)
            timer8.Tick += timer8_Tick;//นับเวลาจาก timer 8
            timer8.Start();//เริ่มนับเมื่อกดปุ่ม
            button7.Enabled = false;//เครื่องที่7จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button42_Click(object sender, EventArgs e)
        {
            hid7();//ซ่อนปุ่มจองเครื่องที่ 7
            timer8.Interval = 3600000;//กำหนดเวลา1 ชั่วโมง(1000=1วินาที)
            timer8.Tick += timer8_Tick;//นับเวลาจาก timer 8
            timer8.Start();//เริ่มนับเมื่อกดปุ่ม
            button7.Enabled = false;//เครื่องที่7จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button43_Click(object sender, EventArgs e)
        {
            hid7();//ซ่อนปุ่มจองเครื่องที่ 7
            timer8.Interval = 5400000;//กำหนดเวลา1 ชั่วโมง 30 นาที(1000=1วินาที)
            timer8.Tick += timer8_Tick;//นับเวลาจาก timer 8
            timer8.Start();//เริ่มนับเมื่อกดปุ่ม
            button7.Enabled = false;//เครื่องที่7จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button44_Click(object sender, EventArgs e)
        {
            hid7();//ซ่อนปุ่มจองเครื่องที่ 7
            timer8.Interval = 7200000;//กำหนดเวลา2 ชั่วโมง(1000=1วินาที)
            timer8.Tick += timer8_Tick;//นับเวลาจาก timer 8
            timer8.Start();//เริ่มนับเมื่อกดปุ่ม
            button7.Enabled = false;//เครื่องที่7จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button45_Click(object sender, EventArgs e)
        {
            hid8();//ซ่อนปุ่มจองเครื่องที่ 8
            timer9.Interval = 1800000;//กำหนดเวลา30นาที(1000=1วินาที)
            timer9.Tick += timer9_Tick;//นับเวลาจาก timer 9
            timer9.Start();//เริ่มนับเมื่อกดปุ่ม
            button8.Enabled = false;//เครื่องที่8จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button46_Click(object sender, EventArgs e)
        {
            hid8();//ซ่อนปุ่มจองเครื่องที่ 8
            timer9.Interval = 3600000;//กำหนดเวลา1 ชั่วโมง(1000=1วินาที)
            timer9.Tick += timer9_Tick;//นับเวลาจาก timer 9
            timer9.Start();//เริ่มนับเมื่อกดปุ่ม
            button8.Enabled = false;//เครื่องที่8จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button47_Click(object sender, EventArgs e)
        {
            hid8();//ซ่อนปุ่มจองเครื่องที่ 8
            timer9.Interval = 5400000;//กำหนดเวลา1 ชั่วโมง 30 นาที(1000=1วินาที)
            timer9.Tick += timer9_Tick;//นับเวลาจาก timer 9
            timer9.Start();//เริ่มนับเมื่อกดปุ่ม
            button8.Enabled = false;//เครื่องที่8จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button48_Click(object sender, EventArgs e)
        {
            hid8();//ซ่อนปุ่มจองเครื่องที่ 8
            timer9.Interval = 7200000;//กำหนดเวลา2 ชั่วโมง(1000=1วินาที)
            timer9.Tick += timer9_Tick;//นับเวลาจาก timer 9
            timer9.Start();//เริ่มนับเมื่อกดปุ่ม
            button8.Enabled = false;//เครื่องที่8จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button49_Click(object sender, EventArgs e)
        {
            hid9();//ซ่อนปุ่มจองเครื่องที่ 9
            timer10.Interval = 1800000;//กำหนดเวลา30นาที(1000=1วินาที)
            timer10.Tick += timer9_Tick;//นับเวลาจาก timer 10
            timer10.Start();//เริ่มนับเมื่อกดปุ่ม
            button9.Enabled = false;//เครื่องที่9จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button50_Click(object sender, EventArgs e)
        {
            hid9();//ซ่อนปุ่มจองเครื่องที่ 9
            timer10.Interval = 3600000;//กำหนดเวลา1 ชั่วโมง(1000=1วินาที)
            timer10.Tick += timer10_Tick;//นับเวลาจาก timer 10
            timer10.Start();//เริ่มนับเมื่อกดปุ่ม
            button9.Enabled = false;//เครื่องที่9จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button51_Click(object sender, EventArgs e)
        {
            hid9();//ซ่อนปุ่มจองเครื่องที่ 9
            timer10.Interval = 5400000;//กำหนดเวลา1 ชั่วโมง 30 นาที(1000=1วินาที)
            timer10.Tick += timer10_Tick;//นับเวลาจาก timer 10
            timer10.Start();//เริ่มนับเมื่อกดปุ่ม
            button9.Enabled = false;//เครื่องที่9จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button52_Click(object sender, EventArgs e)
        {
            hid9();//ซ่อนปุ่มจองเครื่องที่ 9
            timer10.Interval = 7200000;//กำหนดเวลา2 ชั่วโมง(1000=1วินาที)
            timer10.Tick += timer10_Tick;//นับเวลาจาก timer 10
            timer10.Start();//เริ่มนับเมื่อกดปุ่ม
            button9.Enabled = false;//เครื่องที่9จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button53_Click(object sender, EventArgs e)
        {
            hid10();//ซ่อนปุ่มจองเครื่องที่ 10
            timer11.Interval = 1800000;//กำหนดเวลา30นาที(1000=1วินาที)
            timer11.Tick += timer11_Tick;//นับเวลาจาก timer 11
            timer11.Start();//เริ่มนับเมื่อกดปุ่ม
            button10.Enabled = false;//เครื่องที่10จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button54_Click(object sender, EventArgs e)
        {
            hid10();//ซ่อนปุ่มจองเครื่องที่ 10            
            timer11.Interval = 3600000;//กำหนดเวลา1 ชั่วโมง(1000=1วินาที)
            timer11.Tick += timer11_Tick;//นับเวลาจาก timer 11
            timer11.Start();//เริ่มนับเมื่อกดปุ่ม
            button10.Enabled = false;//เครื่องที่10จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button55_Click(object sender, EventArgs e)
        {
            hid10();//ซ่อนปุ่มจองเครื่องที่ 10
            timer11.Interval = 5400000;//กำหนดเวลา1 ชั่วโมง 30 นาที(1000=1วินาที)
            timer11.Tick += timer11_Tick;//นับเวลาจาก timer 11
            timer11.Start();//เริ่มนับเมื่อกดปุ่ม
            button10.Enabled = false;//เครื่องที่10จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button56_Click(object sender, EventArgs e)
        {
            hid10();//ซ่อนปุ่มจองเครื่องที่ 10
            timer11.Interval = 7200000;//กำหนดเวลา2 ชั่วโมง(1000=1วินาที)
            timer11.Tick += timer11_Tick;//นับเวลาจาก timer 11
            timer11.Start();//เริ่มนับเมื่อกดปุ่ม
            button10.Enabled = false;//เครื่องที่10จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button57_Click(object sender, EventArgs e)
        {
            hid11();//ซ่อนปุ่มจองเครื่องที่ 11
            timer12.Interval = 1800000;//กำหนดเวลา30นาที(1000=1วินาที)
            timer12.Tick += timer12_Tick;//นับเวลาจาก timer 12
            timer12.Start();//เริ่มนับเมื่อกดปุ่ม
            button11.Enabled = false;//เครื่องที่11จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button58_Click(object sender, EventArgs e)
        {
            hid11();//ซ่อนปุ่มจองเครื่องที่ 11
            timer12.Interval = 3600000;//กำหนดเวลา1 ชั่วโมง(1000=1วินาที)
            timer12.Tick += timer12_Tick;//นับเวลาจาก timer 12
            timer12.Start();//เริ่มนับเมื่อกดปุ่ม
            button11.Enabled = false;//เครื่องที่11จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button59_Click(object sender, EventArgs e)
        {
            hid11();//ซ่อนปุ่มจองเครื่องที่ 11
            timer12.Interval = 5400000;//กำหนดเวลา1 ชั่วโมง 30 นาที(1000=1วินาที)
            timer12.Tick += timer12_Tick;//นับเวลาจาก timer 12
            timer12.Start();//เริ่มนับเมื่อกดปุ่ม
            button11.Enabled = false;//เครื่องที่11จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button60_Click(object sender, EventArgs e)
        {
            hid11();//ซ่อนปุ่มจองเครื่องที่ 11
            timer12.Interval = 7200000;//กำหนดเวลา2 ชั่วโมง(1000=1วินาที)
            timer12.Tick += timer12_Tick;//นับเวลาจาก timer 12
            timer12.Start();//เริ่มนับเมื่อกดปุ่ม
            button11.Enabled = false;//เครื่องที่11จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button61_Click(object sender, EventArgs e)
        {
            hid12();//ซ่อนปุ่มจองเครื่องที่ 12
            timer13.Interval = 1800000;//กำหนดเวลา30นาที(1000=1วินาที)
            timer13.Tick += timer13_Tick;//นับเวลาจาก timer 13
            timer13.Start();//เริ่มนับเมื่อกดปุ่ม
            button12.Enabled = false;//เครื่องที่12จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button62_Click(object sender, EventArgs e)
        {
            hid12();//ซ่อนปุ่มจองเครื่องที่ 12
            timer13.Interval = 3600000;//กำหนดเวลา1 ชั่วโมง(1000=1วินาที)
            timer13.Tick += timer13_Tick;//นับเวลาจาก timer 13
            timer13.Start();//เริ่มนับเมื่อกดปุ่ม
            button12.Enabled = false;//เครื่องที่12จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button63_Click(object sender, EventArgs e)
        {
            hid12();//ซ่อนปุ่มจองเครื่องที่ 12
            timer13.Interval = 5400000;//กำหนดเวลา1 ชั่วโมง 30 นาที(1000=1วินาที)
            timer13.Tick += timer13_Tick;//นับเวลาจาก timer 13
            timer13.Start();//เริ่มนับเมื่อกดปุ่ม
            button12.Enabled = false;//เครื่องที่12จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button64_Click(object sender, EventArgs e)
        {
            hid12();//ซ่อนปุ่มจองเครื่องที่ 12
            timer13.Interval = 7200000;//กำหนดเวลา2 ชั่วโมง(1000=1วินาที)
            timer13.Tick += timer13_Tick;//นับเวลาจาก timer 13
            timer13.Start();//เริ่มนับเมื่อกดปุ่ม
            button12.Enabled = false;//เครื่องที่12จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button65_Click(object sender, EventArgs e)
        {
            hid13();//ซ่อนปุ่มจองเครื่องที่ 13
            timer14.Interval = 1800000;//กำหนดเวลา30นาที(1000=1วินาที)
            timer14.Tick += timer14_Tick;//นับเวลาจาก timer 14
            timer14.Start();//เริ่มนับเมื่อกดปุ่ม
            button13.Enabled = false;//เครื่องที่13จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button66_Click(object sender, EventArgs e)
        {
            hid13();//ซ่อนปุ่มจองเครื่องที่ 13
            timer14.Interval = 3600000;//กำหนดเวลา1 ชั่วโมง(1000=1วินาที)
            timer14.Tick += timer14_Tick;//นับเวลาจาก timer 14
            timer14.Start();//เริ่มนับเมื่อกดปุ่ม
            button13.Enabled = false;//เครื่องที่13จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button67_Click(object sender, EventArgs e)
        {
            hid13();//ซ่อนปุ่มจองเครื่องที่ 13
            timer14.Interval = 5400000;//กำหนดเวลา1 ชั่วโมง 30 นาที(1000=1วินาที)
            timer14.Tick += timer14_Tick;//นับเวลาจาก timer 14
            timer14.Start();//เริ่มนับเมื่อกดปุ่ม
            button13.Enabled = false;//เครื่องที่13จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button68_Click(object sender, EventArgs e)
        {
            hid13();//ซ่อนปุ่มจองเครื่องที่ 13
            timer14.Interval = 7200000;//กำหนดเวลา2 ชั่วโมง(1000=1วินาที)
            timer14.Tick += timer14_Tick;//นับเวลาจาก timer 14
            timer14.Start();//เริ่มนับเมื่อกดปุ่ม
            button13.Enabled = false;//เครื่องที่13จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button69_Click(object sender, EventArgs e)
        {
            hid14();//ซ่อนปุ่มจองเครื่องที่ 14
            timer15.Interval = 1800000;//กำหนดเวลา30นาที(1000=1วินาที)
            timer15.Tick += timer15_Tick;//นับเวลาจาก timer 15
            timer15.Start();//เริ่มนับเมื่อกดปุ่ม
            button14.Enabled = false;//เครื่องที่14จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button70_Click(object sender, EventArgs e)
        {
            hid14();//ซ่อนปุ่มจองเครื่องที่ 14
            timer15.Interval = 3600000;//กำหนดเวลา1 ชั่วโมง(1000=1วินาที)
            timer15.Tick += timer15_Tick;//นับเวลาจาก timer 15
            timer15.Start();//เริ่มนับเมื่อกดปุ่ม
            button14.Enabled = false;//เครื่องที่14จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button71_Click(object sender, EventArgs e)
        {
            hid14();//ซ่อนปุ่มจองเครื่องที่ 14
            timer15.Interval = 5400000;//กำหนดเวลา1 ชั่วโมง 30 นาที(1000=1วินาที)
            timer15.Tick += timer15_Tick;//นับเวลาจาก timer 15
            timer15.Start();//เริ่มนับเมื่อกดปุ่ม
            button14.Enabled = false;//เครื่องที่14จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button72_Click(object sender, EventArgs e)
        {
            hid14();//ซ่อนปุ่มจองเครื่องที่ 14
            timer15.Interval = 7200000;//กำหนดเวลา2 ชั่วโมง(1000=1วินาที)
            timer15.Tick += timer15_Tick;//นับเวลาจาก timer 15
            timer15.Start();//เริ่มนับเมื่อกดปุ่ม
            button14.Enabled = false;//เครื่องที่14จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button73_Click(object sender, EventArgs e)
        {
            hid15();//ซ่อนปุ่มจองเครื่องที่ 15
            timer16.Interval = 1800000;//กำหนดเวลา30นาที(1000=1วินาที)
            timer16.Tick += timer16_Tick;//นับเวลาจาก timer 16
            timer16.Start();//เริ่มนับเมื่อกดปุ่ม
            button15.Enabled = false;//เครื่องที่15จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button74_Click(object sender, EventArgs e)
        {
            hid15();//ซ่อนปุ่มจองเครื่องที่ 15
            timer16.Interval = 3600000;//กำหนดเวลา1 ชั่วโมง(1000=1วินาที)
            timer16.Tick += timer16_Tick;//นับเวลาจาก timer 16
            timer16.Start();//เริ่มนับเมื่อกดปุ่ม
            button15.Enabled = false;//เครื่องที่15จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button75_Click(object sender, EventArgs e)
        {
            hid15();//ซ่อนปุ่มจองเครื่องที่ 15
            timer16.Interval = 5400000;//กำหนดเวลา1 ชั่วโมง 30 นาที(1000=1วินาที)
            timer16.Tick += timer16_Tick;//นับเวลาจาก timer 16
            timer16.Start();//เริ่มนับเมื่อกดปุ่ม
            button15.Enabled = false;//เครื่องที่15จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button76_Click(object sender, EventArgs e)
        {
            hid15();//ซ่อนปุ่มจองเครื่องที่ 15
            timer16.Interval = 7200000;//กำหนดเวลา2 ชั่วโมง(1000=1วินาที)
            timer16.Tick += timer16_Tick;//นับเวลาจาก timer 16
            timer16.Start();//เริ่มนับเมื่อกดปุ่ม
            button15.Enabled = false;//เครื่องที่15จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button77_Click(object sender, EventArgs e)
        {
            hid16();//ซ่อนปุ่มจองเครื่องที่ 16
            timer17.Interval = 1800000;//กำหนดเวลา30นาที(1000=1วินาที)
            timer17.Tick += timer17_Tick;//นับเวลาจาก timer 17
            timer17.Start();//เริ่มนับเมื่อกดปุ่ม
            button16.Enabled = false;//เครื่องที่16จะจองไม่ได้จนกว่าจะหมดเวลา
        }

        private void button78_Click(object sender, EventArgs e)
        {
            hid16();//ซ่อนปุ่มจองเครื่องที่ 16
            timer17.Interval = 3600000;//กำหนดเวลา1 ชั่วโมง(1000=1วินาที)
            timer17.Tick += timer17_Tick;//นับเวลาจาก timer 17
            timer17.Start();//เริ่มนับเมื่อกดปุ่ม
            button16.Enabled = false;      //เครื่องที่16จะจองไม่ได้จนกว่าจะหมดเวลา 
        }

        private void button79_Click(object sender, EventArgs e)
        {
            hid16();//ซ่อนปุ่มจองเครื่องที่ 16
            timer17.Interval = 5400000;//กำหนดเวลา1 ชั่วโมง 30 นาที(1000=1วินาที)
            timer17.Tick += timer17_Tick;
            timer17.Start();//เริ่มนับเมื่อกดปุ่ม
            button16.Enabled = false;    //เครื่องที่16จะจองไม่ได้จนกว่าจะหมดเวลา       
        }

        private void button80_Click(object sender, EventArgs e)
        {
            hid16();//ซ่อนปุ่มจองเครื่องที่ 16
            timer17.Interval = 7200000;//กำหนดเวลา2 ชั่วโมง(1000=1วินาที)
            timer17.Tick += timer17_Tick;
            timer17.Start();//เริ่มนับเมื่อกดปุ่ม
            button16.Enabled = false;//เครื่องที่16จะจองไม่ได้จนกว่าจะหมดเวลา            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            button2.Enabled = true; //เปิดใช้งานปุ่มจองคอมพิวเตอร์เครื่องที่ 2
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            button3.Enabled = true;//เปิดใช้งานปุ่มจองคอมพิวเตอร์เครื่องที่ 3
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            button4.Enabled = true;//เปิดใช้งานปุ่มจองคอมพิวเตอร์เครื่องที่ 4
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            button5.Enabled = true;//เปิดใช้งานปุ่มจองคอมพิวเตอร์เครื่องที่ 5
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            button6.Enabled = true;//เปิดใช้งานปุ่มจองคอมพิวเตอร์เครื่องที่ 6
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            button7.Enabled = true;//เปิดใช้งานปุ่มจองคอมพิวเตอร์เครื่องที่ 7
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            button8.Enabled = true;//เปิดใช้งานปุ่มจองคอมพิวเตอร์เครื่องที่ 8
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            button9.Enabled = true;//เปิดใช้งานปุ่มจองคอมพิวเตอร์เครื่องที่ 9
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            button10.Enabled = true;//เปิดใช้งานปุ่มจองคอมพิวเตอร์เครื่องที่ 10
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            button11.Enabled = true;//เปิดใช้งานปุ่มจองคอมพิวเตอร์เครื่องที่ 11
        }

        private void timer13_Tick(object sender, EventArgs e)
        {
            button12.Enabled = true;//เปิดใช้งานปุ่มจองคอมพิวเตอร์เครื่องที่ 12
        }

        private void timer14_Tick(object sender, EventArgs e)
        {
            button13.Enabled = true;//เปิดใช้งานปุ่มจองคอมพิวเตอร์เครื่องที่ 13
        }

        private void timer15_Tick(object sender, EventArgs e)
        {
            button14.Enabled = true;//เปิดใช้งานปุ่มจองคอมพิวเตอร์เครื่องที่ 14
        }

        private void timer16_Tick(object sender, EventArgs e)
        {
            button15.Enabled = true;//เปิดใช้งานปุ่มจองคอมพิวเตอร์เครื่องที่ 15
        }

        private void timer17_Tick(object sender, EventArgs e)
        {
            button16.Enabled = true;//เปิดใช้งานปุ่มจองคอมพิวเตอร์เครื่องที่ 16
        }

        private void button81_Click(object sender, EventArgs e)
        {
            hid1(); hid2(); hid3(); hid4();
            hid5(); hid6(); hid7(); hid8();
            hid9(); hid10(); hid11(); hid12();
            hid13(); hid14(); hid15(); hid16(); //ซ่อนปุ่มจองทุกๆปุ่มเมื่อกดปุ่มยกเลิก
        }
    }
}
