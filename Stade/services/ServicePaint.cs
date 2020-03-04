using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stade
{
    class ServicePaint
    {
        public void drawCurve(List<PointF> points, Pen penCurrent, Panel pan)
        {
            Graphics g = pan.CreateGraphics();
            PointF[] pf = points.ToArray<PointF>();
            if (pf.Length > 0)
            {
                g.DrawCurve(penCurrent, pf, 0);
            }
        }
        //Vérifier si un point appartient à un rectangle
        public bool isInside(Rectangle rect, Point point)
        {
            if (rect.Contains(point))
            {
                return true;
            }

            return false;
        }

        float getMaximumX(List<PointF> points)
        {
            return points.Max(p => p.X);
        }
        float getMinimumX(List<PointF> points)
        {
            return points.Min(p => p.X);
        }
        float getMaximumY(List<PointF> points)
        {
            return points.Max(p => p.Y);
        }
        float getMinimumY(List<PointF> points)
        {
            return points.Min(p => p.Y);
        }
        public List<PointF> getPointsRectangle(List<PointF> points)
        {
            //Rectangle rectangle = new Rectangle();
            List<PointF> pointsRect = new List<PointF>();
            float maxX = getMaximumX(points);
            float minX = getMinimumX(points);
            float maxY = getMaximumY(points);
            float minY = getMinimumY(points);

            PointF pointA = new PointF(minX, minY);
            PointF pointB = new PointF(maxX, minY);
            PointF pointC = new PointF(maxX, maxY);
            PointF pointD = new PointF(minX, maxY);
            pointsRect.Add(pointA);
            pointsRect.Add(pointB);
            pointsRect.Add(pointC);
            pointsRect.Add(pointD);

            /*rectangle.X = int.Parse(minX.ToString());
            rectangle.Y = int.Parse(minY.ToString());
            int width = int.Parse((maxX - minX).ToString());
            int height = int.Parse((maxY - minY).ToString());
            rectangle.Size = new Size(width, height);
            return rectangle;*/

            return pointsRect;
        }
        public List<Rectangle> drawPlaces(Panel panel, float width, float height, float space, List<PointF> points)
        {
            PointF[] point = getPointsRectangle(points).ToArray<PointF>();
            PointF[] coo = points.ToArray<PointF>();

            List<Rectangle> resultat = new List<Rectangle>();
            Graphics graphics = panel.CreateGraphics();
            GraphicsPath path = new GraphicsPath();
            path.AddPolygon(coo);
            int temp = int.Parse(point[0].X.ToString());
            int temp_y = int.Parse(point[0].Y.ToString());
            while (temp_y < point[2].Y)
 
            {
                temp = (int)point[0].X;

                while (temp < point[1].X)
                {
                    
                    Point A = new Point(temp + (int)height, temp_y + (int)width);
                    Point B = new Point(temp + (int)height + (int)height, temp_y + (int)width);
                    Point C = new Point(temp + (int)height + (int)height, temp_y + (int)width + (int)width);
                    Point D = new Point(temp + (int)height, temp_y + (int)width + (int)width);

                    if (path.IsVisible(A) && path.IsVisible(B) && path.IsVisible(C) && path.IsVisible(D))
                    {
                        Rectangle rect = new Rectangle(A.X, A.Y, (int)width, (int)height);
                        resultat.Add(rect);
                    }

                    temp += (int)width + (int)space;

                }
                temp_y += (int)height + (int)space;
            }
            return resultat;
        }
        public List<Rectangle> getSameColumns(List<Rectangle> list, Rectangle temp)
        {
            List<Rectangle> rects = new List<Rectangle>();
            int i = 0; 
            for(i=0; i<list.Count; i++)
            {
                if(temp.X == list.ElementAt(i).X)
                {
                    Rectangle toDelete = list.ElementAt(i);
                    rects.Add(toDelete);
                }
            }
            return rects;
        }

        //Dessiner une courbe
        public void drawCurve(Panel panel, List<PointF> points, Pen penCurrent)
        {
            MessageBox.Show("taille des points " + points.Count);
            Graphics g = panel.CreateGraphics();
            PointF[] listPoints = points.ToArray<PointF>();
            g.DrawCurve(penCurrent, listPoints, 0, 4, 0);
            //g.DrawCurve(penCurrent, listPoints, 0, 4, 0);
        }

        //Dessiner dans un rectangle
        public void drawString(Panel panel, Rectangle rect, Brush brush, String text, Font myFont)
        {
            Graphics graphics = panel.CreateGraphics();
            graphics.DrawString("" + text, myFont, brush, rect);
        }
        public void numeroterPlaces(Panel panel, List<Rectangle> places, List<Rectangle> annules, List<ClassChaise> chaises, int debut, int sensVertical, int sensHorizontal, int direction)
        {
            Graphics graphics = panel.CreateGraphics();
            int i = 0, size = places.Count;
            Font myFont = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);

            for (i = 0; i < size; i++)
            {
                //chaises.ElementAt(i).position = debut;
                graphics.DrawString("", myFont, Brushes.YellowGreen, places.ElementAt(i));
                if (!annules.Contains(places.ElementAt(i)))
                {
                    chaises.ElementAt(i).position = debut;
                    this.drawString(panel, places.ElementAt(i), Brushes.Blue, "" + debut, myFont);
                    debut++;
                }else
                {
                    chaises.ElementAt(i).position = -1;
                    graphics.FillRectangle(Brushes.Black, places.ElementAt(i));
                    this.drawString(panel, places.ElementAt(i), Brushes.Red, "X", myFont);
                }
                
            }

            //Direction horizontale
            if (direction == 1)
            {
                /*if(sensHorizontal==1 && sensVertical == 1)
                {*/
                    //SH: gauche-droite, SV:hautbas
                    /*for(i=0; i<size; i++, debut++)
                    {
                        //chaises.ElementAt(i).position = debut;
                        graphics.DrawString("" + debut, myFont, Brushes.YellowGreen, places.ElementAt(i));
                    }*/
                //}
                if (sensHorizontal == -1 && sensVertical == -1)
                {
                    //SH:droite-gauche, SV:bashaut
                    /*for (i=places.Count-1; i>=0; i--, debut++)
                    {
                        chaises.ElementAt(i).position = debut;
                        graphics.DrawString("" + debut, myFont, Brushes.YellowGreen, places.ElementAt(i));
                    }*/
                }
            }

            //SH:droite-gauche, SV:hautbas
            /*for (i=places.Count-1; i>=0; i--)
            {
                Rectangle actu = places.ElementAt(i);
                List<Rectangle> columns = this.getSameColumns(places, actu);
                for(j=0; j<columns.Count; j++, debut++)
                {
                    graphics.DrawString("" + debut, myFont, Brushes.YellowGreen, columns.ElementAt(j));
                    places.Remove(columns.ElementAt(j));
                }
                i = places.Count - 1;
            } */

            //SH: gauche-droite, SV:bashaut
            /*for (i = 0; i <places.Count; i++)
            {
                Rectangle actu = places.ElementAt(i);
                List<Rectangle> columns = this.getSameColumns(places, actu);
                for (j = 0; j < columns.Count; j++, debut++)
                {
                    graphics.DrawString("" + debut, myFont, Brushes.YellowGreen, columns.ElementAt(j));
                    places.Remove(columns.ElementAt(j));
                }
                //i = places.Count - 1;
            }*/

            //SV: gauche-droite, SV:hautbas

            //SV: gauche-droite, SV:bashaut

            //SV:droite-gauche, SV:hautbas

            //SV:droite-gauche, SV:bashaut
        }

        //Check if polygon
        public void isPolygon(List<PointF> points)
        {
            if (points.Count < 3)
            {
                throw new Exception("Un polygone contient au moins 3 points");
            }
        }

        //Draw rectangle
        public void drawRectangle(Panel panel, Rectangle rect, Pen pen)
        {
            Graphics graphics = panel.CreateGraphics();
            graphics.DrawRectangle(pen, rect);
        }

        //Draw point and polygon
        public void drawPoint(Panel panel, float cooX, float cooY)
        {
            Graphics graphics = panel.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            Brush brush = Brushes.Black;
            graphics.FillRectangle(brush, cooX, cooY, 2, 2);
        }
        public void drawPolygon(Panel panel, List<PointF> listPoint, Pen pen)
        {
            Graphics graphics = panel.CreateGraphics();
            graphics.DrawPolygon(pen, listPoint.ToArray<PointF>());
        }

        //Generate point to insert in DB
        public String generatePointDB(List<PointF> listPoint)
        {
            String result = "";
            int i = 0, size = listPoint.Count;
            for(i=0; i<size-1; i++)
            {
                result += listPoint.ElementAt(i).X + " " + listPoint.ElementAt(i).Y + ";";
            }
            result += listPoint.ElementAt(i).X + " " + listPoint.ElementAt(i).Y;
            return result;
        }
        
        //Generate points to paint
        public List<PointF> generatePoints(String pointDB)
        {
            List<PointF> listPoint = new List<PointF>();
            String[] points = pointDB.Split(';');
            int i = 0, size = points.Length;
            for(i=0; i<size; i++)
            {
                String[] coordinates = points[i].Split(' ');
                PointF point = new PointF(float.Parse(coordinates[0]), float.Parse(coordinates[1]));
                listPoint.Add(point);
            }
            return listPoint;
        }
    }
}
