﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ClassBoxData
{
    class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length 
        {   get
            {
                return this.length;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                else
                {
                    this.length = value;
                }
            }        
        }
        public double Width 
        {   get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                else
                {
                    this.width = value;
                }
            }
        }
        public double Height 
        {
            get
            {
                return this.height;
            }
           
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                else
                {
                    this.height = value;
                }
            }
        }
        public double SurfaceArea()
        {
            double area = (2 * Length * Width) + (2 * Length * Height) + (2 * Width * Height);
            return area ;
        }
        public double LateralSurfaceArea()
        {
            double area = (2 * Length * Height) + (2 * Width * Height);
            return area ;
        }
        public double Volume()
        {
            double area = Length * Width * Height;
            return area;
        }
       
    }
}
