using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using HMS.Properties;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace HMS
{
    public class Exporter
    {
        public string ExportToPDF(string[] columnNames, DataTable dt, string filename)
        {
            int noOfColumns = columnNames.Length;
            int noOfRows = dt.Rows.Count;

            Table headerTable = new Table(1, 1);
            headerTable.Padding = 4;
            headerTable.BorderWidth = 0;
            headerTable.DefaultCellBorderColor = new Color(System.Drawing.Color.White);

            Font calTableHeader = FontFactory.GetFont("Calibri", 8, Font.BOLD, new Color(System.Drawing.Color.Black));
            Cell headerCell = new Cell(new Phrase("Bangladesh Golf Federation", calTableHeader));
            headerCell.HorizontalAlignment = 1;
            headerTable.AddCell(headerCell, 0, 0);



            Table table = new Table(noOfColumns, noOfRows);
            table.AutoFillEmptyCells = true;
            table.Padding = 2;
            table.BorderWidth = 0;
            table.DefaultCellBorderColor = new Color(System.Drawing.Color.DarkGray);

            Font calRow = FontFactory.GetFont("Calibri", 6, Font.NORMAL, new Color(System.Drawing.Color.Black));
            Font calHeader = FontFactory.GetFont("Calibri", 6, Font.NORMAL, new Color(System.Drawing.Color.DarkGreen));




            Cell cell;
            for (int columnNo = 0; columnNo < noOfColumns; columnNo++)
            {
                cell = new Cell(new Phrase(columnNames[columnNo], calHeader));
                table.AddCell(cell, 0, columnNo);
            }
            for (int rowNo = 1; rowNo <= noOfRows; rowNo++)
            {
                for (int columnNo = 0; columnNo < noOfColumns; columnNo++)
                {
                    cell = new Cell(new Phrase(dt.Rows[rowNo - 1][columnNo].ToString(), calRow));
                    table.AddCell(cell, rowNo, columnNo);
                }
            }




            string filePath = String.Format(@"{0}\BGFH\UserFiles\PDF\{1}\", Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments), filename);
            filename = String.Format(@"{0}{1}_{2}.pdf", filePath, filename, DateTime.Now.ToString("ddMMMyy"));
            if (!Directory.Exists(filePath))
                Directory.CreateDirectory(filePath);


            Document document = new Document();

            PdfWriter.GetInstance(document, new FileStream(filename, FileMode.Create));
            document.Open();
            //document.AddHeader("Date: ", DateTime.Today);
            //document.AddTitle("BGF");

            document.Add(headerTable);
            document.Add(table);
            document.Close();


            return filename;
        }        

        public string ExportToPDF(string applicationTitle, string fileTitle, string criteria, string printInfo, string[] columnNames, DataTable dt, string filename)
        {

            try
            {
                Image logoImage = Image.GetInstance(Application.StartupPath + @"\logo-url\Logo.png");
                //Image logoImage = Image.GetInstance(HMS.Properties.Settings.Default.HospitalLogoPath);
                logoImage.Alignment = Element.ALIGN_CENTER;
                //logoImage.ScalePercent(5f);
                //myImage.SetAbsolutePosition(45, 45); 

                Table headerTable = new Table(1, 1);
                headerTable.Width = 87;
                headerTable.Padding = 0;
                headerTable.BorderWidth = 0;
                headerTable.DefaultCellBorderColor = new Color(System.Drawing.Color.White);
                headerTable.Cellspacing = 0;
                headerTable.AutoFillEmptyCells = true;
                Font calApplicationTitle = FontFactory.GetFont("Calibri", 11, Font.BOLD, new Color(System.Drawing.Color.Black));
                Font calTableHeader = FontFactory.GetFont("Calibri", 9, Font.BOLD, new Color(System.Drawing.Color.Black));
                Font calTableDummy = FontFactory.GetFont("Calibri", 9, Font.NORMAL, new Color(System.Drawing.Color.White));

                Cell headerCell = new Cell(new Phrase(applicationTitle, calApplicationTitle));
                headerCell.HorizontalAlignment = 1;
                headerTable.AddCell(headerCell, 0, 0);

                headerCell = new Cell(new Phrase(fileTitle, calTableHeader));
                headerCell.HorizontalAlignment = 1;
                headerTable.AddCell(headerCell, 1, 0);
                if (criteria != "")
                {
                    headerCell = new Cell(new Phrase(criteria, calTableHeader));
                    headerCell.HorizontalAlignment = 1;
                    headerTable.AddCell(headerCell, 2, 0);
                }

                headerCell = new Cell(new Phrase(printInfo, calTableHeader));
                headerCell.HorizontalAlignment = 1;
                headerTable.AddCell(headerCell, 3, 0);

                headerCell = new Cell(new Phrase(" . ", calTableDummy));
                headerCell.HorizontalAlignment = 1;
                headerTable.AddCell(headerCell, 4, 0);

                int noOfColumns = columnNames.Length;
                int noOfRows = dt.Rows.Count;
                Table table = new Table(noOfColumns, noOfRows);
                table.Width = 87;
                table.AutoFillEmptyCells = true;
                table.Padding = 2;
                table.BorderWidth = 0;
                table.DefaultCellBorderColor = new Color(System.Drawing.Color.DarkGray);
                table.CellsFitPage = true;
                Font calRow = FontFactory.GetFont("Calibri", 6, Font.NORMAL, new Color(System.Drawing.Color.Black));
                //Font calHeader = FontFactory.GetFont("Calibri", 8, Font.BOLD, new Color(System.Drawing.Color.DarkGreen));
                Font calHeader = FontFactory.GetFont("Calibri", 8, Font.BOLD, new Color(System.Drawing.Color.ForestGreen));



                Cell cell = new Cell();

                //Phrase phrase = new Phrase(columnNames[columnNo], calHeader);



                for (int columnNo = 0; columnNo < noOfColumns; columnNo++)
                {
                    cell = new Cell(new Phrase(columnNames[columnNo], calHeader));
                    cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                    table.AddCell(cell, 0, columnNo);
                    cell.BackgroundColor = new CMYKColor(65, 0, 83, 0);
                }


                for (int rowNo = 1; rowNo <= noOfRows; rowNo++)
                {
                    for (int columnNo = 0; columnNo < noOfColumns; columnNo++)
                    {
                        cell = new Cell(new Phrase(dt.Rows[rowNo - 1][columnNo].ToString(), calRow));

                        table.AddCell(cell, rowNo, columnNo);
                    }
                }




                string filePath = String.Format(@"{0}\HMS\UserFile\PDF\{1}\", Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments), filename);
                filename = String.Format(@"{0}{1}_{2}.pdf", filePath, filename, DateTime.Now.ToString("ddMMMyy"));
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }
                if (File.Exists(filename))
                {
                    File.Delete(filename);
                }
        
                     
                Rectangle rectangle = new Rectangle(PageSize.A4);
                Document document = new Document(rectangle, 10f, 10f, 35f, 20f);
                PdfWriter.GetInstance(document, new FileStream(filename, FileMode.Create));
                document.Open();
                document.Add(logoImage);
                document.Add(headerTable);

                document.Add(table);
                document.Close();
                return filename;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}