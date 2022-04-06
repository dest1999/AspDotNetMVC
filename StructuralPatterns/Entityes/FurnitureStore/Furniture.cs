using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns
{
    internal class Furniture
    {
        public string Designation { get; }
        public decimal Price { get; }
        public int Weight { get; }
        public int Length { get; }
        public int Width { get; }
        public int Height { get; }
        public string? Description { get; }

        public static Furniture Create(
            string designation, 
            decimal price, 
            int weight = 0, 
            int length = 0, 
            int width = 0, 
            int height = 0, 
            string? description = null)
        {
            return new Furniture(designation, price, weight, length, width, height, description);
        }

        private Furniture(
            string designation,
            decimal price,
            int weight = 0,
            int length = 0,
            int width = 0,
            int height = 0,
            string? description = null)
        {
            if (string.IsNullOrWhiteSpace(designation))
            {
                throw new ArgumentNullException("Designation must be a value");
            }
            Designation = designation;
            if (price <= 0)
            {
                throw new Exception("Price must be a greater than zero");
            }
            Price = price;
            Weight = weight;
            Length = length;
            Width = width;
            Height = height;
            Description = description;
        }

    }
}
