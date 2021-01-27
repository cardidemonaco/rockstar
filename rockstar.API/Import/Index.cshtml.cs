using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace rockstar.API.Import
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }

        public void OnPost()
        {
            //Find file of rockstars...
            string fileName = @"../../rockstar.Data/Sample Data/rockstars.xlsx";

            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (SpreadsheetDocument doc = SpreadsheetDocument.Open(fs, false))
                {
                    WorkbookPart workbookPart = doc.WorkbookPart;
                    SharedStringTablePart sstpart = workbookPart.GetPartsOfType<SharedStringTablePart>().First();
                    SharedStringTable sst = sstpart.SharedStringTable;

                    WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();
                    Worksheet sheet = worksheetPart.Worksheet;

                    var cells = sheet.Descendants<Cell>();
                    var rows = sheet.Descendants<Row>();

                    //Go through each row of the spreadsheet...
                    foreach (Row row in rows)
                    {
                        //Skip header row...
                        if (row.RowIndex != 1 && row.RowIndex <= 1000) //TODO: Find a way to dynamically find last row
                        {
                            //Go through each rockstar...
                            if (row.Elements<Cell>().ElementAtOrDefault(3) != null && row.Elements<Cell>().ElementAt(3).CellValue.Text != "")
                            {

                            }
                        }
                    }
                }
            }

        }
    }
}
