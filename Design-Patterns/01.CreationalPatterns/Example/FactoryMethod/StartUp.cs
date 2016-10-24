using FactoryMethod.Contracts;
using FactoryMethod.Models;
using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    public class StartUp
    {
        public static void Main()
        {
            IList<Image> images = new List<Image>();

            images.Add(new JpegImage());
            images.Add(new GifImage());
            ImageCollection imageRepository = new ImageCollection(images);
            Console.WriteLine(imageRepository.CreateThumbnails());
        }
    }
}
