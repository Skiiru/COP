﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AODL.Document.SpreadsheetDocuments;
using AODL.Document.Content.Tables;
using AODL.Document.Content.Text;
using AODL.Document.Styles;namespace OpenOfficeLib
{
    public partial class OpenOfficeComponent : Component
    {
        public OpenOfficeComponent()
        {
            InitializeComponent();
        }

        public OpenOfficeComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public string CreateDocument(string path, string listName, Data tbTitle, Dictionary<int,List<Data>> data)
        {
            try
            {
                //создаем новый документ типа электронная таблица
                SpreadsheetDocument spreadsheetDocument = new SpreadsheetDocument();
                spreadsheetDocument.New();
                //создаем новую таблицу
                Table table = new Table(spreadsheetDocument, listName, "tablefirst");
                //создаем новую ячейку, без дополнительных стилей
                Cell cell = table.CreateCell("cell001");
                cell.OfficeValueType = "string";
                cell.CellStyle.CellProperties.Border = tbTitle.border;
                //создаем новый параграф
                Paragraph paragraph = ParagraphBuilder.CreateSpreadsheetParagraph(spreadsheetDocument);

                //---------------------------------!!!!!!!!!!!!!!!!!!----------------------------------
                //добавляем в него - текст
                FormatedText ftext = new FormatedText(spreadsheetDocument, tbTitle.style, tbTitle.data);
                paragraph.TextContent.Add(ftext);
                //теперь добавляем созданный параграф в ячейку
                cell.Content.Add(paragraph);
                table.InsertCellAt(1, 1, cell);
                foreach (var column in data)
                {
                    int k = 1;
                    foreach (var d in column.Value)
                    {
                        k++;
                        //clear
                        //paragraph.TextContent.Clear();
                        //cell.Content.Clear();
                        Paragraph paragraph1 = ParagraphBuilder.CreateSpreadsheetParagraph(spreadsheetDocument);
                        Cell cell1 = table.CreateCell("cell001");
                        cell1.OfficeValueType = "string";
                        cell1.CellStyle.CellProperties.Border = d.border;
                        ftext = new FormatedText(spreadsheetDocument, d.style, d.data);
                        paragraph1.TextContent.Add(ftext);
                        cell1.Content.Add(paragraph1);
                        table.InsertCellAt(k + 1, column.Key + 1, cell1);
                    }
                }
                //осталось вставить готовый объект с таблицей в документ и сохранить его
                spreadsheetDocument.TableCollection.Add(table);
                spreadsheetDocument.SaveTo(path);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
    public class Data
    {
        public string data;
        public string border;
        public string style;

        
        public Data(string data, string border,string style)
        {
            this.data = data;
            this.border = border;
            this.style = style;
        }
    }
}
