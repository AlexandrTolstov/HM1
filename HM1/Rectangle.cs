using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM1
{
    public class Rectangle
    {
        private int sideA;
        private int sideB;
        private int sideC;

        private string message;

        private int numOfRectHorizontal;
        private int numOfRectVertical;
        private int numOfRectSumm;

        public string Message { get => message;
            set
            {
                if(message != "")
                {
                    message += "; ";
                    message += value;
                }
                else
                {
                    message += value;
                }
            }
        }

        public int SideA
        {
            get
            {
                return sideA;
            }
            set
            {
                if (value >= 0)
                {
                    sideA = value;
                }
                else
                {
                    sideA = -value;
                }
            }
        }
        public int SideB
        {
            get
            {
                return sideB;
            }
            set
            {
                if (value >= 0)
                {
                    sideB = value;
                }
                else
                {
                    sideB = -value;
                }
            }
        }
        public int SideC
        {
            get
            {
                return sideC;
            }
            set
            {
                if (value > sideA || value > sideB)
                {
                    if (value > sideA)
                    {
                        Message = "Сторона квадрата больше стороны A";
                        sideC = sideA;
                    }
                    if (value > sideB)
                    {
                        Message = "Сторона квадрата больше стороны B";
                        sideC = sideB;
                    }
                }
                else
                {
                    if (value >= 0)
                    {
                        sideC = value;
                    }
                    else
                    {
                        sideC = -value;
                    }
                }
            }
        }
        public int NumOfRectSumm
        {
            get
            {
                return numOfRectSumm;
            }
        } //Только возвращает
        public int NumOfRectHorizontal
        {
            get
            {
                return numOfRectHorizontal;
            }
        } //Только возвращает
        public int NumOfRectVertical
        {
            get
            {
                return numOfRectVertical;
            }
        } //Только возвращает

        public Rectangle(int SideA = 0, int SideB = 0, int SideC = 0)
        {
            this.SideA = SideA;
            this.SideB = SideB;
            this.SideC = SideC;
            Calculate();
        }
        public void Calculate()
        {
            if (SideA > 0)
            {
                numOfRectVertical = SideA / SideC;
            }
            else
            {
                numOfRectVertical = 0;
            }
            if (SideB > 0)
            {
                numOfRectHorizontal = SideB / SideC;
            }
            else
            {
                numOfRectHorizontal = 0;
            }
            numOfRectSumm = numOfRectHorizontal * numOfRectVertical;
        }
    }
}
