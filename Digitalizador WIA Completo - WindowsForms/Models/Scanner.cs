using System.Runtime.InteropServices;
using System.Windows.Forms;
using WIA;

namespace Digitalizador_WIA_Completo___WindowsForms
{
    public class Scanner
    {
        private readonly DeviceInfo _deviceInfo;
        private readonly int resolucaoDPI = 300;
        private readonly int larguraPixel = 2500;
        private readonly int alturaPixel = 3400;
        private readonly int colorMode = 1;

        public Scanner(DeviceInfo deviceInfo)
        {
            this._deviceInfo = deviceInfo;
        }

        public ImageFile ScanPNG()
        {
            // Conecta com o dispositivo
            Device device = this._deviceInfo.Connect();

            // Seleciona o scanner
            Item ScanerItem = device.Items[1];

            try
            {
                ConfiguracoesScanner(ScanerItem, resolucaoDPI, 0, 0, larguraPixel, alturaPixel, 0, 0, colorMode);

                object scanResult = ScanerItem.Transfer("{B96B3CAF-0728-11D3-9D7B-0000F81EF32E}");

                if (scanResult != null)
                {
                    ImageFile imageFile = (ImageFile)scanResult;
                    return imageFile;
                }
            }
            catch (COMException e)
            {
                uint errorCode = (uint)e.ErrorCode;

                // Captura 2 dos mais comuns dos erros
                if (errorCode == 0x80210006)
                {
                    MessageBox.Show("A scanner não está pronta ou está ocupada!", "Erro!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (errorCode == 0x80210064)
                {
                    MessageBox.Show("O processo de digitalização foi cancelado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro não conhecido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return new ImageFile();
        }

        public ImageFile ScanJPEG()
        {
            // Conecta com o dispositivo
            Device device = this._deviceInfo.Connect();

            // Seleciona o scanner
            Item ScanerItem = device.Items[1];

            try
            {
                ConfiguracoesScanner(ScanerItem, resolucaoDPI, 0, 0, larguraPixel, alturaPixel, 0, 0, colorMode);

                object scanResult = ScanerItem.Transfer("{B96B3CAE-0728-11D3-9D7B-0000F81EF32E}");

                if (scanResult != null)
                {
                    ImageFile imageFile = (ImageFile)scanResult;
                    return imageFile;
                }
            }
            catch (COMException e)
            {
                uint errorCode = (uint)e.ErrorCode;

                // Captura 2 dos mais comuns dos erros
                if (errorCode == 0x80210006)
                {
                    MessageBox.Show("A scanner não está pronta ou está ocupada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (errorCode == 0x80210064)
                {
                    MessageBox.Show("O processo de digitalização foi cancelado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro não conhecido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return new ImageFile();
        }

        public ImageFile ScanTIFF()
        {
            // Conecta com o dispositivo
            Device device = this._deviceInfo.Connect();

            // Seleciona o scanner
            Item ScanerItem = device.Items[1];

            try
            {
                ConfiguracoesScanner(ScanerItem, resolucaoDPI, 0, 0, larguraPixel, alturaPixel, 0, 0, colorMode);

                object scanResult = ScanerItem.Transfer("{B96B3CB1-0728-11D3-9D7B-0000F81EF32E}");

                if (scanResult != null)
                {
                    ImageFile imageFile = (ImageFile)scanResult;
                    return imageFile;
                }
            }
            catch (COMException e)
            {
                uint errorCode = (uint)e.ErrorCode;

                // Captura 2 dos mais comuns dos erros
                if (errorCode == 0x80210006)
                {
                    MessageBox.Show("A scanner não está pronta ou está ocupada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (errorCode == 0x80210064)
                {
                    MessageBox.Show("O processo de digitalização foi cancelado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro não conhecido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return new ImageFile();
        }

        public ImageFile ScanBMP()
        {
            // Conecta com o dispositivo
            Device device = this._deviceInfo.Connect();

            // Seleciona o scanner
            Item ScanerItem = device.Items[1];

            try
            {
                ConfiguracoesScanner(ScanerItem, resolucaoDPI, 0, 0, larguraPixel, alturaPixel, 0, 0, colorMode);

                object scanResult = ScanerItem.Transfer("{B96B3CAB-0728-11D3-9D7B-0000F81EF32E}");

                if (scanResult != null)
                {
                    ImageFile imageFile = (ImageFile)scanResult;
                    return imageFile;
                }
            }
            catch (COMException e)
            {
                uint errorCode = (uint)e.ErrorCode;

                // Captura 2 dos mais comuns dos erros
                if (errorCode == 0x80210006)
                {
                    MessageBox.Show("A scanner não está pronta ou está ocupada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (errorCode == 0x80210064)
                {
                    MessageBox.Show("O processo de digitalização foi cancelado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro não conhecido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return new ImageFile();
        }

        public ImageFile ScanGIF()
        {
            // Conecta com o dispositivo
            Device device = this._deviceInfo.Connect();

            // Seleciona o scanner
            Item ScanerItem = device.Items[1];

            try
            {
                ConfiguracoesScanner(ScanerItem, resolucaoDPI, 0, 0, larguraPixel, alturaPixel, 0, 0, colorMode);
                
                object scanResult = ScanerItem.Transfer("{B96B3CB0-0728-11D3-9D7B-0000F81EF32E}");

                if (scanResult != null)
                {
                    ImageFile imageFile = (ImageFile)scanResult;
                    return imageFile;
                }
            }
            catch (COMException e)
            {
                uint errorCode = (uint)e.ErrorCode;

                // Captura 2 dos mais comuns dos erros
                if (errorCode == 0x80210006)
                {
                    MessageBox.Show("A scanner não está pronta ou está ocupada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (errorCode == 0x80210064)
                {
                    MessageBox.Show("O processo de digitalização foi cancelado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro não conhecido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return new ImageFile();
        }

        private static void ConfiguracoesScanner(IItem scannnerItem, int resolucaoDPI, int scannerInicioEsquerdaPixel, int scannerInicioTopoPixel, int larguraPixel, int alturaPixel, int iluminacaoPorcentagem, int contrastePercentagem, int colorMode)
        {
            const string WIA_SCAN_COLOR_MODE = "6146";
            const string WIA_HORIZONTAL_SCAN_RESOLUTION_DPI = "6147";
            const string WIA_VERTICAL_SCAN_RESOLUTION_DPI = "6148";
            const string WIA_HORIZONTAL_SCAN_START_PIXEL = "6149";
            const string WIA_VERTICAL_SCAN_START_PIXEL = "6150";
            const string WIA_HORIZONTAL_SCAN_SIZE_PIXELS = "6151";
            const string WIA_VERTICAL_SCAN_SIZE_PIXELS = "6152";
            const string WIA_SCAN_BRIGHTNESS_PERCENTS = "6154";
            const string WIA_SCAN_CONTRAST_PERCENTS = "6155";
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_RESOLUTION_DPI, resolucaoDPI);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_RESOLUTION_DPI, resolucaoDPI);
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_START_PIXEL, scannerInicioEsquerdaPixel);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_START_PIXEL, scannerInicioTopoPixel);
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_SIZE_PIXELS, larguraPixel);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_SIZE_PIXELS, alturaPixel);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_BRIGHTNESS_PERCENTS, iluminacaoPorcentagem);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_CONTRAST_PERCENTS, contrastePercentagem);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_COLOR_MODE, colorMode);
        }

        private static void SetWIAProperty(IProperties properties, object propName, object propValue)
        {
            Property prop = properties.get_Item(ref propName);
            prop.set_Value(ref propValue);
        }

        public override string ToString()
        {
            return (string)this._deviceInfo.Properties["Name"].get_Value();
        }
    }
}
