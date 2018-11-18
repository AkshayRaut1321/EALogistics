namespace ExtraFunctions
{
    class CExFuncy
    {
        internal static string setNumberPlaceholder(int number, int digit)
        {
            string num = number.ToString();
            for (int i = 0; i < digit; i++)
            {
                if (num.Length < digit)
                {
                    num = "0" + num;
                }
            }
            return num;
        }

        //  Error identifiers start from -128 to -1.

        /// <summary>
        /// Saves data in Microsoft Word file in Bill format using MS Office Word PIAs.
        /// </summary>
        //private void saveDoc()
        //{
        //    Microsoft.Office.Interop.Word._Application WApp = new Microsoft.Office.Interop.Word.Application();
        //    //  underscore in Application class name is (optional and) to eliminate ambiguity of its methods from their counterpats in relative event class.

        //    //  read word doc
        //    //Document openDoc = a.Documents.Open(@"E:\test.docx");

        //    //  Save word doc
        //    object oMissing = System.Reflection.Missing.Value;
        //    _Document WDoc = new Document();
        //    WApp.Visible = true;
        //    WDoc = WApp.Documents.Add();

        //    //Insert a paragraph at the beginning of the document.
        //    Microsoft.Office.Interop.Word.Paragraph WParTitle = WDoc.Content.Paragraphs.Add();
        //    WDoc.PageSetup.TopMargin = 40f;
        //    WParTitle.Range.Text = "Jay Mataji Logistics";
        //    WParTitle.Range.set_Style(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTitle);
        //    WParTitle.Format.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
        //    WDoc.SaveAs2("E:\\ZOut.docx");

        //    WParTitle.Range.Text += "433, Central Facility, Building NO.2, APMC Market II, Sector-19, Vashi, Navi Mumbai – 400705.";
        //    WParTitle.Range.set_Style(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleBookTitle);
        //    WParTitle.Range.Font.Name = "Cambria";
        //    WParTitle.Range.Font.Size = 14f;
        //    WDoc.Save();

        //    /* \v to add manual line break.
        //     * \n to add new paragraph.
        //     * try \r to add parahraph instead of writing these double paragraph codes             
        //     */
        //    WDoc.Paragraphs.Add();
        //    Microsoft.Office.Interop.Word.Paragraph WParRest = WDoc.Paragraphs[3];
        //    WParRest.Range.Text = "To M/s. BMG Chemicals PVT. LTD.\v216, Gokul Arcade, Subhash road, Ville Parle (E), Mumbai 400057.\n";
        //    WParRest.Range.Font.Size = 12f;
        //    WDoc.Save();

        //    Range footerRange = WDoc.Sections[1].Footers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
        //    footerRange.Font.Size = 16;
        //    footerRange.Text = "Service tax to be paid directly by the consignor/consignee to the Government Department for the Consignment covered under this document.";
        //    WDoc.Save();

        //    object start = 212;
        //    object end = 212;

        //    //  Read line by line, not sure it works
        //    //Microsoft.Office.Interop.Word.LineNumbering l;
        //    //object oStart = l.Active;
        //    //bool bEOF = false;
        //    //string sLine;
        //    //saveDoc.Characters[1].Select();
        //    //int index = 0;
        //    //do
        //    //{
        //    //    object unit = WdUnits.wdLine;
        //    //    object count = 1;
        //    //    a.Selection.MoveEnd(ref unit, ref count);
        //    //    sLine = a.Selection.Text;

        //    //  starts Add Table
        //    Range tableLocation = WDoc.Range(ref start, ref end);
        //    //string lno = WParRest.Range.get_Information(WdInformation.wdFirstCharacterLineNumber).ToString();
        //    //WApp.Selection.TypeParagraph();
        //    //WApp.Selection.TypeText("abc");
        //    //WApp.Selection.Tables.Add(tableLocation, 3, 7);
        //    //WDoc.Paragraphs.Add();
        //    Microsoft.Office.Interop.Word.Paragraph WParTable = WDoc.Paragraphs[WDoc.Paragraphs.Count];
        //    WDoc.Tables.Add(WParTable.Range, 3, 7);
        //    WDoc.Tables[1].Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
        //    WDoc.Tables[1].Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;

        //    //  Adjust rows
        //    WDoc.Tables[1].Rows[1].Height = 30f;
        //    WDoc.Tables[1].Rows[2].Height = 300f;
        //    WDoc.Tables[1].Rows[3].Height = 30f;

        //    //  Adjust columns
        //    WDoc.Tables[1].Cell(1, 1).Range.Text = "Date";
        //    WDoc.Tables[1].Cell(1, 2).Range.Text = "L. R. no.";
        //    WDoc.Tables[1].Cell(1, 3).Range.Text = "Invoice no.";
        //    WDoc.Tables[1].Cell(1, 4).Range.Text = "Description";
        //    WDoc.Tables[1].Cell(1, 5).Range.Text = "Rate";
        //    WDoc.Tables[1].Cell(1, 6).Range.Text = "Weight";
        //    WDoc.Tables[1].Cell(1, 7).Range.Text = "Amount";

        //    WDoc.Save();
        //    WDoc.Close();
        //    WApp.Quit();
        //    WDoc = null;
        //    WApp = null;
        //}

    }
}
