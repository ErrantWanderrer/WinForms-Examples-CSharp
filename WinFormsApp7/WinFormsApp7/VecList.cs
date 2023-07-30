using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp7
{
    class VecList
    {
        public List<Vector> List = new List<Vector>();
        private int currentPos = -1;
        Graphics g = null;
        public void Add(Vector v)//Добавление элемента
        {
            List.Add(v);
            currentPos++;
            this.Draw();
        }
        public void Del()
        {
            if (Count < 1) 
                return;
            List.RemoveAt(currentPos);
            if (currentPos > 0) 
                currentPos--;
            if (Count < 1) 
                currentPos = -1;
            Draw();
        }
        public void Clear()//Очистка списка
        {
            List.Clear();
            currentPos = -1;
            this.Draw();
        }
        public int Count//Количество элементов
        {
            get { return List.Count; }
        }
        public void NextPos()
        {
            if(currentPos + 1 < Count)
            {
                ++currentPos;
                this.Draw();
            }
        }
        public void PreviousPos()
        {
            if (currentPos > 0)
            {
                --currentPos;
                this.Draw();
            }
        }
        public int getPos()
        {
            return currentPos;
        }
        public void setGraphics(Graphics gg)
        {
            g = gg;
        }
        public void Draw()
        {
            if (g == null) return;
            g.Clear(Color.White);
            if (Count < 1) return;
            g.FillEllipse(new SolidBrush(Color.LightBlue), List[getPos()].getX(), List[getPos()].getY(), 50, 50);
            Pen pen = new Pen(Color.Red, 3);
            for (int i = 0; i < Count; i++)
            {
                g.DrawString(i.ToString(), new Font("Arial", 12), new SolidBrush(Color.Black), List[i].getX() + 17, List[i].getY() + 17);
                g.DrawEllipse(pen, List[i].getX(), List[i].getY(), 50, 50);
            }
        }
    }
}
