using SawingFactory.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SawingFactory
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //using (var context = new FactoryContext())
            //{
            //    string dir = @"C:\Users\SSS\Desktop\Skill09_TP2018\Сессия 1\images\Изделия\";
            //    foreach (var m in context.Products)
            //    {
            //        var path = dir + m.ProductId + ".jpg";
            //        if (!File.Exists(path)) continue;
            //        Image image = Image.FromFile(path);
            //        MemoryStream stream = new MemoryStream();
            //        image.Save(stream, ImageFormat.Jpeg);
            //        m.Image = stream.ToArray();
            //    }

            //    string dir1 = @"C:\Users\SSS\Desktop\Skill09_TP2018\Сессия 1\images\Ткани\";
            //    foreach (var m in context.Materials)
            //    {
            //        var path = dir1 + m.MaterialId + ".jpg";
            //        if (!File.Exists(path)) continue;
            //        Image image = Image.FromFile(path);
            //        MemoryStream stream = new MemoryStream();
            //        image.Save(stream, ImageFormat.Jpeg);
            //        m.Image = stream.ToArray();
            //    }
            //    string dir2 = @"C:\Users\SSS\Desktop\Skill09_TP2018\Сессия 1\images\Фурнитура\";
            //    foreach (var m in context.Furnitures)
            //    {
            //        var path = dir2 + m.FurnitureId + ".jpg";
            //        if (!File.Exists(path)) continue;
            //        Image image = Image.FromFile(path);
            //        MemoryStream stream = new MemoryStream();
            //        image.Save(stream, ImageFormat.Jpeg);
            //        m.Image = stream.ToArray();
            //    }
            //    context.SaveChanges();
            //}

            Application.Run(new AuthForm());
        }
    }
}
