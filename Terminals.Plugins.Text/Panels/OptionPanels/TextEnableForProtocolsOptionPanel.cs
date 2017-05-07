namespace Terminals.Plugins.Text.Panels.OptionPanels
{
    using Terminals.Connection.Panels.OptionPanels;
    using Terminals.Plugins.Text.Connection;
    using Terminals.Connection.Manager;

    public class TextEnableForProtocolsOptionPanel : EnableProtocolOptionPanel
    {
        public TextEnableForProtocolsOptionPanel()
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        }

        #region Public Methods (1)
        public override string DefaultProtocolName
        {
            get
            {
                return typeof(TextConnection).GetProtocolName();
            }
        }
        #endregion
    }
}