using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShapesMaker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Line line = new Line(new Point(100,200), new Point(700,200));
            //Rectangle rectangle = new Rectangle(new Point(400, 50), new Point(400, 0), new Point(500, 0), new Point
            //    (500, 50));
            //Square square = new Square(new Point(300, 50), new Point(300, 0), new Point(350, 0), new Point
            //    (350, 50));
            //Circle circle = new Circle(new Point(200, 50), 50);
            //Triangle triangle = new Triangle(new Point(600, 100), new Point(650, 50), new Point(700, 100));
            //Elipse elipse = new Elipse(new Point(50, 50), 100, 50);

            // Message boxes to know the cirtain coordinates of my shapes
            /*MessageBox.Show(elipse.Draw());
            MessageBox.Show(circle.Draw());
            MessageBox.Show(square.Draw());
            MessageBox.Show(rectangle.Draw());
            MessageBox.Show(triangle.Draw());
            MessageBox.Show(line.Draw());*/

            // Create a canvas because Window.AddChild will throw exception when U add more than one 
            // object to it, because Window is a ContentControl. Page allowed only 1 chil, so this 
            // child will be a canv and I will place all other objects in canv;
            
            //List <Shape> shapes = new List <Shape>();
            //shapes.Add(line);
            //shapes.Add(triangle);
            //shapes.Add(square);
            //shapes.Add(circle);
            //shapes.Add(rectangle);
            //shapes.Add(elipse);

            //foreach (var item in shapes)
            //{
            //    figuresCanvas.Children.Add(item.Draw());
            //}
         
           
        }

        

        private void drawBtn_Click(object sender, RoutedEventArgs e)
        {
            if(chooseFigureCombBox.SelectedItem == null)
            {
                MessageBox.Show("Please, select the figure to draw");
                return;
            }

            TextBlock saveChoosenText = (TextBlock)chooseFigureCombBox.SelectedItem;

            switch (saveChoosenText.Text)
            {
                
                case "Triangle":
                    MessageBox.Show("Draw triangle");
                    try
                    {
                        Triangle triangle = new Triangle(new Point(int.Parse(P1X_txtBox.Text), int.Parse(P1Y_txtBox.Text)), new Point(int.Parse(P2X_txtBox.Text), int.Parse(P2Y_txtBox.Text)), new Point(int.Parse(P3X_txtBox.Text), int.Parse(P3Y_txtBox.Text)));
                        figuresCanvas.Children.Add(triangle.Draw());
                    }
                    catch 
                    {
                        MessageBox.Show("Incorrect input, please try again");                        
                    }
                                  
                    break;




                case "Line":
                    MessageBox.Show("Draw line");
                    try
                    {
                        Line line = new Line(new Point(int.Parse(P1X_txtBox.Text), int.Parse(P1Y_txtBox.Text)), new Point(int.Parse(P2X_txtBox.Text), int.Parse(P2Y_txtBox.Text)));
                        figuresCanvas.Children.Add(line.Draw());
                    }
                    catch
                    {
                        MessageBox.Show("Incorrect input, please try again");
                    }

                    break;

                case "Rectangle":
                    MessageBox.Show("Draw rectangle");
                    try
                    {
                        Rectangle rectangle = new Rectangle(new Point(int.Parse(P1X_txtBox.Text), int.Parse(P1Y_txtBox.Text)), new Point(int.Parse(P2X_txtBox.Text), int.Parse(P2Y_txtBox.Text)), new Point(int.Parse(P3X_txtBox.Text), int.Parse(P3Y_txtBox.Text)), new Point(int.Parse(P4X_txtBox.Text), int.Parse(P4Y_txtBox.Text)));
                        figuresCanvas.Children.Add(rectangle.Draw());
                    }
                    catch
                    {
                        MessageBox.Show("Incorrect input, please try again");
                    }

                    break;

                case "Square":
                    MessageBox.Show("Draw square");
                    try
                    {
                        Square square = new Square(new Point(int.Parse(P1X_txtBox.Text), int.Parse(P1Y_txtBox.Text)), new Point(int.Parse(P2X_txtBox.Text), int.Parse(P2Y_txtBox.Text)), new Point(int.Parse(P3X_txtBox.Text), int.Parse(P3Y_txtBox.Text)), new Point(int.Parse(P4X_txtBox.Text), int.Parse(P4Y_txtBox.Text)));
                        figuresCanvas.Children.Add(square.Draw());
                    }
                    catch
                    {
                        MessageBox.Show("Incorrect input, please try again");
                    }

                    break;

                case "Circle":
                    MessageBox.Show("Draw circle");
                    try
                    {
                        Circle circle = new Circle(new Point(int.Parse(P1X_txtBox.Text), int.Parse(P1Y_txtBox.Text)), int.Parse(Radius_txtBox.Text));
                        figuresCanvas.Children.Add(circle.Draw());
                    }
                    catch
                    {
                        MessageBox.Show("Incorrect input, please try again");
                    }

                    break;

                case "Ellipse":
                    MessageBox.Show("Draw ellipse");
                    try
                    {
                        Elipse elipse = new Elipse(new Point(int.Parse(P1X_txtBox.Text), int.Parse(P1Y_txtBox.Text)), int.Parse(Width_txtBox.Text), int.Parse(Height_txtBox.Text));
                        figuresCanvas.Children.Add(elipse.Draw());
                    }
                    catch
                    {
                        MessageBox.Show("Incorrect input, please try again");
                    }

                    break;




                default:
                    MessageBox.Show("smth strange...");
                    break;




            }
        }
    }
}
