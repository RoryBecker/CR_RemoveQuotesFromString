using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.CodeRush.Core;
using DevExpress.CodeRush.PlugInCore;
using DevExpress.CodeRush.StructuralParser;

namespace CR_RemoveQuotesFromString
{
    public partial class PlugIn1 : StandardPlugIn
    {
        // DXCore-generated code...
        #region InitializePlugIn
        public override void InitializePlugIn()
        {
            base.InitializePlugIn();
            registerRemoveQuotesFromString();
        }
        #endregion
        #region FinalizePlugIn
        public override void FinalizePlugIn()
        {
            //
            // TODO: Add your finalization code here.
            //

            base.FinalizePlugIn();
        }
        #endregion
        public void registerRemoveQuotesFromString()
        {
            DevExpress.CodeRush.Core.Action RemoveQuotesFromString = new DevExpress.CodeRush.Core.Action(components);
            ((System.ComponentModel.ISupportInitialize)(RemoveQuotesFromString)).BeginInit();
            RemoveQuotesFromString.ActionName = "RemoveQuotesFromString";
            RemoveQuotesFromString.ButtonText = "RemoveQuotesFromString"; // Used if button is placed on a menu.
            RemoveQuotesFromString.RegisterInCR = true;
            RemoveQuotesFromString.Execute += RemoveQuotesFromString_Execute;
            RemoveQuotesFromString.CheckAvailability += RemoveQuotesFromString_CheckAvailability;
            ((System.ComponentModel.ISupportInitialize)(RemoveQuotesFromString)).EndInit();
        }
        private void RemoveQuotesFromString_CheckAvailability(CheckActionAvailabilityEventArgs ea)
        {
            ea.Available = CodeRush.Source.ActiveString != null;
        }
        private void RemoveQuotesFromString_Execute(ExecuteEventArgs ea)
        {
            TextString TheString = CodeRush.Source.ActiveString;
            var TheRange = TheString.Range;
            CodeRush.Documents.ActiveTextDocument.SetText(new SourceRange(TheRange.Start.OffsetPoint(0, -1),TheRange.End.OffsetPoint(0,1)), (string)TheString.PrimitiveExpression.PrimitiveValue);
            
        }
    }
}