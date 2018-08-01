using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Web.UI;
using SawingFactory.DAL.Entities;
using System.Linq;
using System.IO;

namespace SawingFactory.Forms
{
    public partial class MaterialsStockReport : SawingFactory.Forms.BaseNestedForm
    {
        public MaterialsStockReport()
        {
            InitializeComponent();
        }

        private void MaterialsStockReport_Load(object sender, EventArgs e)
        {
            using (var context = new FactoryContext())
            {
                var materials = context.MaterialRolls
                .GroupBy(roll => roll.Material).AsEnumerable()
                .Select(group => new
                {
                    group.Key.MaterialId,
                    group.Key.Name,
                    Count = group.Count(),
                    Area = group.Sum(m => m.Area),
                    Price = group.Sum(m => m.Price)
                });

                var furnitures = context.FurnitureStocks
    .GroupBy(f => f.Furniture)
    .Select(group => new
    {
        group.Key.FurnitureId,
        group.Key.Name,
        Count = group.Count(),
        Weight = group.Sum(f => f.Furniture.Weight),
        Price = group.Sum(f => f.Furniture.Price)
    });

                var string_writer = new StringWriter();
                using (var writer = new HtmlTextWriter(string_writer))
                {
                    WriteTable(
                        writer,
                        new List<string>()
                    {
                        "Артикул",
                        "Название",
                        "Количество",
                        "Площадь",
                        "Цена"
                    },
                        "Остатки тканей"
                        );
                    foreach (var item in materials)
                    {
                        WriteRow(writer, new List<string>()
                        {
                            item.MaterialId,
                            item.Name,
                            item.Count.ToString(),
                            item.Area.ToString(),
                            item.Price.ToString()
                        });

                    }

                    writer.RenderEndTag();

                    WriteTable(
                        writer,
                        new List<string>()
                    {
                        "Артикул",
                        "Название",
                        "Количество",
                        "Цена"
                    },
                        "Остатки фурнитуры"
                        );
                    foreach (var item in furnitures)
                    {
                        WriteRow(writer, new List<string>()
                        {
                            item.FurnitureId,
                            item.Name,
                            item.Count.ToString(),
                            item.Price.ToString()
                        });

                    }
                    //writer.RenderEndTag();

                }
                webBrowser1.DocumentText = string_writer.ToString();
            }
        }

        private static void WriteRow(HtmlTextWriter writer, List<string> row)
        {
            writer.RenderBeginTag(HtmlTextWriterTag.Tr);
            foreach (var item in row)
            {
                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                writer.Write(item);
                writer.RenderEndTag();
            }
            writer.RenderEndTag();
        }

        private static void WriteTable(HtmlTextWriter writer, List<string> headers, string title)
        {
            writer.RenderBeginTag(HtmlTextWriterTag.H1);
            writer.Write(title);
            writer.RenderEndTag();
            writer.AddAttribute(HtmlTextWriterAttribute.Border, "solid");
            writer.RenderBeginTag(HtmlTextWriterTag.Table);
            WriteRow(writer, headers);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Print();
        }
    }
}
