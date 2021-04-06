using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw_a_figure
{
    public partial class Form1 : Form
    {
        Point xy;
        Point x2y2;

        Pen pen = new Pen(Color.Red, 5);
        SolidBrush brush = new SolidBrush(Color.Red);

        Boolean ismousedown;
        public Form1()
        {
            InitializeComponent();

            List<string> figures = new List<string> { "TriAngle", "Circle", "Rectangle" };
            comboBox1.Items.AddRange(figures.ToArray());
            comboBox1.SelectedIndex = 2;
        }

        IFactory FigureFactory { get; set; }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        
        var item = comboBox1.SelectedItem.ToString();
            if (item == "TriAngle")
            {
                FigureFactory = new TriAngleFactory();
            }
            else if (item == "Rectangle")
            {
                FigureFactory = new RectangleFactory();
            }
            else if (item == "Circle")
            {
                FigureFactory = new CircleFactory();
            }
        }

        List<IFigure> Figures = new List<IFigure>();
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!checkBox1.Checked)
            {
                if (radioButton1.Checked)
                {
                    if (FigureFactory.GetFigure() is Rectangle rect)
                    {


                        rect.Color = FigureColor;
                        rect.Point = e.Location;
                        rect.Size = new Size(int.Parse(widthTxtb.Text), int.Parse(heightTxtb.Text));


                        rect.isFilled = true;

                        Figures.Add(rect);
                    }

                    if (FigureFactory.GetFigure() is Circle circle)
                    {


                        circle.Color = FigureColor;
                        circle.Point = e.Location;
                        circle.Size = new Size(int.Parse(widthTxtb.Text), int.Parse(heightTxtb.Text));


                        circle.isFilled = true;

                        Figures.Add(circle);
                    }

                    if (FigureFactory.GetFigure() is TriAngle triAngle)
                    {


                        triAngle.Color = FigureColor;
                        triAngle.Point = e.Location;
                        triAngle.Size = new Size(int.Parse(widthTxtb.Text), int.Parse(heightTxtb.Text));


                        triAngle.isFilled = true;

                        Figures.Add(triAngle);
                    }

                    this.Refresh();
                }




                if (radioButton2.Checked)
                {
                    if (FigureFactory.GetFigure() is Rectangle rect)
                    {


                        rect.Color = FigureColor;
                        rect.Point = e.Location;
                        rect.Size = new Size(int.Parse(widthTxtb.Text), int.Parse(heightTxtb.Text));


                        rect.isFilled = false;

                        Figures.Add(rect);
                    }

                    if (FigureFactory.GetFigure() is Circle circle)
                    {


                        circle.Color = FigureColor;
                        circle.Point = e.Location;
                        circle.Size = new Size(int.Parse(widthTxtb.Text), int.Parse(heightTxtb.Text));


                        circle.isFilled = false;

                        Figures.Add(circle);
                    }

                    if (FigureFactory.GetFigure() is TriAngle triAngle)
                    {


                        triAngle.Color = FigureColor;
                        triAngle.Point = e.Location;
                        triAngle.Size = new Size(int.Parse(widthTxtb.Text), int.Parse(heightTxtb.Text));


                        triAngle.isFilled = false;

                        Figures.Add(triAngle);
                    }

                    this.Refresh();
                }

            }


            if (checkBox1.Checked)
            {
               

                


                if (radioButton1.Checked)
                {
                    if (FigureFactory.GetFigure() is Rectangle rect)
                    {


                        rect.Color = FigureColor;
                        rect.Point = e.Location;
                        rect.Size = new Size(Math.Abs(x2y2.X - xy.X), Math.Abs(x2y2.Y - xy.Y));


                        rect.isFilled = true;

                        Figures.Add(rect);
                    }

                    if (FigureFactory.GetFigure() is Circle circle)
                    {


                        circle.Color = FigureColor;
                        circle.Point = e.Location;
                        circle.Size = new Size(Math.Abs(x2y2.X - xy.X), Math.Abs(x2y2.Y - xy.Y));


                        circle.isFilled = true;

                        Figures.Add(circle);
                    }

                    if (FigureFactory.GetFigure() is TriAngle triAngle)
                    {


                        triAngle.Color = FigureColor;
                        triAngle.Point = e.Location;
                        triAngle.Size = new Size(Math.Abs(x2y2.X - xy.X), Math.Abs(x2y2.Y - xy.Y));


                        triAngle.isFilled = true;

                        Figures.Add(triAngle);
                    }

                    this.Refresh();
                }


                if (radioButton2.Checked)
                {
                    if (FigureFactory.GetFigure() is Rectangle rect)
                    {


                        rect.Color = FigureColor;
                        rect.Point = e.Location;
                        rect.Size = new Size(Math.Abs(x2y2.X - xy.X), Math.Abs(x2y2.Y - xy.Y));


                        rect.isFilled = false;

                        Figures.Add(rect);
                    }

                    if (FigureFactory.GetFigure() is Circle circle)
                    {


                        circle.Color = FigureColor;
                        circle.Point = e.Location;
                        circle.Size = new Size(Math.Abs(x2y2.X - xy.X), Math.Abs(x2y2.Y - xy.Y));


                        circle.isFilled = false;

                        Figures.Add(circle);
                    }

                    if (FigureFactory.GetFigure() is TriAngle triAngle)
                    {


                        triAngle.Color = FigureColor;
                        triAngle.Point = e.Location;
                        triAngle.Size = new Size(Math.Abs(x2y2.X - xy.X), Math.Abs(x2y2.Y - xy.Y));


                        triAngle.isFilled = false;

                        Figures.Add(triAngle);
                    }

                    this.Refresh();
                }

            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
      
            if (ismousedown == true)
            {
              
                        x2y2 = e.Location;


                this.Refresh();

            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (checkBox1.Checked)
            {
                x2y2 = e.Location;
                ismousedown = false;


            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            xy = e.Location;
            ismousedown = true;


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (!checkBox1.Checked)
            {
                using (var a = e.Graphics)
                {
                    Pen pen = new Pen(FigureColor, 3);
                    SolidBrush brush = new SolidBrush(FigureColor);


                    foreach (var item in Figures)
                    {
                        if (item is Rectangle rect)
                        {
                            if (rect.isFilled)
                            {
                                a.FillRectangle(brush, rect.Point.X, rect.Point.Y, rect.Size.Width, rect.Size.Height);


                            }

                            else
                            {
                                a.DrawRectangle(pen, rect.Point.X, rect.Point.Y, rect.Size.Width, rect.Size.Height);
                            }
                        }

                        if (item is Circle circle)
                        {
                            if (circle.isFilled)
                            {
                                a.FillEllipse(brush, circle.Point.X, circle.Point.Y, circle.Size.Width, circle.Size.Height);
                            }

                            else
                            {
                                a.DrawEllipse(pen, circle.Point.X, circle.Point.Y, circle.Size.Width, circle.Size.Height);
                            }
                        }


                        if (item is TriAngle triAngle)

                        {



                            Point[] points = new Point[3]
                             {


                                           new Point(triAngle.Point.X + triAngle.Size.Width / 2, triAngle.Point.Y),
                                           new Point(triAngle.Point.X + triAngle.Size.Width , triAngle.Point.Y+ triAngle.Size.Height),
                                           new Point(triAngle.Point.X, triAngle.Point.Y+ triAngle.Size.Height),


                             };

                            if (triAngle.isFilled)
                            {
                                a.FillPolygon(brush, points);
                            }

                            else
                            {
                                a.DrawPolygon(pen, points);
                            }
                        }

                    }
                }
            }

            if (checkBox1.Checked)
            {
                using (var a = e.Graphics)
                {
                    Pen pen = new Pen(FigureColor, 3);
                    SolidBrush brush = new SolidBrush(FigureColor);


                    foreach (var item in Figures)
                    {
                        if (item is Rectangle rect)
                        {


                            if (rect.isFilled)
                            {
                             
                                   a.FillRectangle(brush, Math.Min(xy.X, x2y2.X), Math.Min(xy.Y, x2y2.Y), Math.Abs(x2y2.X - xy.X), Math.Abs(x2y2.Y - xy.Y));
                                
                            }

                            else
                            {
                              
                                   a.DrawRectangle(pen, Math.Min(xy.X, x2y2.X), Math.Min(xy.Y, x2y2.Y), Math.Abs(x2y2.X - xy.X), Math.Abs(x2y2.Y - xy.Y));
                                

                            }
                        }

                        if (item is Circle circle)
                        {
                            if (circle.isFilled)

                            {
                                a.FillEllipse(brush, Math.Min(xy.X, x2y2.X), Math.Min(xy.Y, x2y2.Y), Math.Abs(x2y2.X - xy.X), Math.Abs(x2y2.Y - xy.Y));
                            }

                            else
                            {
                                a.DrawEllipse(pen, Math.Min(xy.X, x2y2.X), Math.Min(xy.Y, x2y2.Y), Math.Abs(x2y2.X - xy.X), Math.Abs(x2y2.Y - xy.Y));
                            }
                        }

                        if (item is TriAngle triAngle)

                        {

                            Point[] points = new Point[3]
                                {


                                           new Point(Math.Min(xy.X, x2y2.X) + Math.Abs(x2y2.X - xy.X) / 2, Math.Min(xy.Y, x2y2.Y)),
                                           new Point(Math.Min(xy.X, x2y2.X) + Math.Abs(x2y2.X - xy.X), Math.Min(xy.Y, x2y2.Y)+ Math.Abs(x2y2.Y - xy.Y)),
                                           new Point(Math.Min(xy.X, x2y2.X),  Math.Min(xy.Y, x2y2.Y)+ Math.Abs(x2y2.Y - xy.Y)),


                                };

                            if (triAngle.isFilled)
                            {
                                a.FillPolygon(brush, points);
                            }

                            else
                            {
                                a.DrawPolygon(pen, points);

                            }

                        }
                        
                        
                    }
                }
            }
        }




        Color FigureColor { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            var result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                FigureColor = colorDialog.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Figures.Clear();
            
                    this.Refresh();
            
            this.Invalidate();





        }


    }



    interface IFigure
    {
        Point Point { get; set; }
        Size Size { get; set; }
        Color Color { get; set; }

        bool isFilled { get; set; }
    }


    class Rectangle : IFigure
    {
        public Point Point { get; set; }
        public Size Size { get; set; }
        public Color Color { get; set; }

        public bool isFilled { get; set; }
    }



    class Circle : IFigure
    {
        public Point Point { get; set; }
        public Size Size { get; set; }
        public Color Color { get; set; }

        public bool isFilled { get; set; }
    }


    class TriAngle : IFigure
    {
        public Point Point { get; set; }
        public Size Size { get; set; }
        public Color Color { get; set; }

        public bool isFilled { get; set; }
    }


    interface IFactory
    {
        IFigure GetFigure();
    }

    class CircleFactory : IFactory
    {
        public IFigure GetFigure()
        {
            return new Circle();
        }
    }


    class RectangleFactory : IFactory
    {
        public IFigure GetFigure()
        {
            return new Rectangle();
        }
    }


    class TriAngleFactory : IFactory
    {
        public IFigure GetFigure()
        {
            return new TriAngle();
        }
    }








}
