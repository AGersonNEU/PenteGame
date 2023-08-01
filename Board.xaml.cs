using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PenteGame
{
    /// <summary>
    /// Interaction logic for Board.xaml
    /// </summary>
    public partial class Board : Window
    {
        public static String playerTurn = GlobalVariables.playerOne.Name;

        
        
        public Board()
        {
            InitializeComponent();
            //J10 is center of Board
            Button A19 = (Button)BoardOfButtons.FindName("A19");
            A19.Opacity = 0;
            A19.IsEnabled = true;

            Button A18 = (Button)BoardOfButtons.FindName("A18");
            A18.Opacity = 0;
            A18.IsEnabled = true;

            Button A17 = (Button)BoardOfButtons.FindName("A17");
            A17.Opacity = 0;
            A17.IsEnabled = true;

            Button A16 = (Button)BoardOfButtons.FindName("A16");
            A16.Opacity = 0;
            A16.IsEnabled = true;

            Button A15 = (Button)BoardOfButtons.FindName("A15");
            A15.Opacity = 0;
            A15.IsEnabled = true;

            Button A14 = (Button)BoardOfButtons.FindName("A14");
            A14.Opacity = 0;
            A14.IsEnabled = true;

            Button A13 = (Button)BoardOfButtons.FindName("A13");
            A13.Opacity = 0;
            A13.IsEnabled = true;

            Button A12 = (Button)BoardOfButtons.FindName("A12");
            A12.Opacity = 0;
            A12.IsEnabled = true;

            Button A11 = (Button)BoardOfButtons.FindName("A12");
            A11.Opacity = 0;
            A11.IsEnabled = true;

            Button A10 = (Button)BoardOfButtons.FindName("A12");
            A10.Opacity = 0;
            A10.IsEnabled = true;

            Button A9 = (Button)BoardOfButtons.FindName("A12");
            A9.Opacity = 0;
            A9.IsEnabled = true;

            Button A8 = (Button)BoardOfButtons.FindName("A12");
            A8.Opacity = 0;
            A8.IsEnabled = true;

            Button A7 = (Button)BoardOfButtons.FindName("A12");
            A7.Opacity = 0;
            A7.IsEnabled = true;

            Button A6 = (Button)BoardOfButtons.FindName("A12");
            A6.Opacity = 0;
            A6.IsEnabled = true;

            Button A5 = (Button)BoardOfButtons.FindName("A12");
            A5.Opacity = 0;
            A5.IsEnabled = true;

            Button A4 = (Button)BoardOfButtons.FindName("A12");
            A4.Opacity = 0;
            A4.IsEnabled = true;

            Button A3 = (Button)BoardOfButtons.FindName("A12");
            A3.Opacity = 0;
            A3.IsEnabled = true;

            Button A2 = (Button)BoardOfButtons.FindName("A12");
            A2.Opacity = 0;
            A2.IsEnabled = true;

            Button A1 = (Button)BoardOfButtons.FindName("A12");
            A1.Opacity = 0;
            A1.IsEnabled = true;

            Button B19 = (Button)BoardOfButtons.FindName("A12");
            B19.Opacity = 0;
            B19.IsEnabled = true;

            Button B18 = (Button)BoardOfButtons.FindName("A12");
            B18.Opacity = 0;
            B18.IsEnabled = true;

            Button B17 = (Button)BoardOfButtons.FindName("A12");
            B17.Opacity = 0;
            B17.IsEnabled = true;

            Button B16 = (Button)BoardOfButtons.FindName("A12");
            B16.Opacity = 0;
            B16.IsEnabled = true;

            Button B15 = (Button)BoardOfButtons.FindName("A12");
            B15.Opacity = 0;
            B15.IsEnabled = true;

            Button B14 = (Button)BoardOfButtons.FindName("A12");
            B14.Opacity = 0;
            B14.IsEnabled = true;

            Button B13 = (Button)BoardOfButtons.FindName("A12");
            B13.Opacity = 0;
            B13.IsEnabled = true;

            Button B12 = (Button)BoardOfButtons.FindName("A12");
            B12.Opacity = 0;
            B12.IsEnabled = true;

            Button B11 = (Button)BoardOfButtons.FindName("A12");
            B11.Opacity = 0;
            B11.IsEnabled = true;

            Button B10 = (Button)BoardOfButtons.FindName("A12");
            B10.Opacity = 0;
            B10.IsEnabled = true;

            Button B9 = (Button)BoardOfButtons.FindName("A12");
            B9.Opacity = 0;
            B9.IsEnabled = true;

            Button B8 = (Button)BoardOfButtons.FindName("A12");
            B8.Opacity = 0;
            B8.IsEnabled = true;

            Button B7 = (Button)BoardOfButtons.FindName("A12");
            B7.Opacity = 0;
            B7.IsEnabled = true;

            Button B6 = (Button)BoardOfButtons.FindName("A12");
            B6.Opacity = 0;
            B6.IsEnabled = true;

            Button B5 = (Button)BoardOfButtons.FindName("A12");
            B5.Opacity = 0;
            B5.IsEnabled = true;

            Button B4 = (Button)BoardOfButtons.FindName("A12");
            B4.Opacity = 0;
            B4.IsEnabled = true;

            Button B3 = (Button)BoardOfButtons.FindName("A12");
            B3.Opacity = 0;
            B3.IsEnabled = true;

            Button B2 = (Button)BoardOfButtons.FindName("A12");
            B2.Opacity = 0;
            B2.IsEnabled = true;

            Button B1 = (Button)BoardOfButtons.FindName("A12");
            B1.Opacity = 0;
            B1.IsEnabled = true;

            Button C19 = (Button)BoardOfButtons.FindName("A12");
            C19.Opacity = 0;
            C19.IsEnabled = true;

            Button C18 = (Button)BoardOfButtons.FindName("A12");
            C18.Opacity = 0;
            C18.IsEnabled = true;

            Button C17 = (Button)BoardOfButtons.FindName("A12");
            C17.Opacity = 0;
            C17.IsEnabled = true;

            Button C16 = (Button)BoardOfButtons.FindName("A12");
            C16.Opacity = 0;
            C16.IsEnabled = true;

            Button C15 = (Button)BoardOfButtons.FindName("A12");
            C15.Opacity = 0;
            C15.IsEnabled = true;

            Button C14 = (Button)BoardOfButtons.FindName("A12");
            C14.Opacity = 0;
            C14.IsEnabled = true;

            Button C13 = (Button)BoardOfButtons.FindName("A12");
            C13.Opacity = 0;
            C13.IsEnabled = true;

            Button C12 = (Button)BoardOfButtons.FindName("A12");
            C12.Opacity = 0;
            C12.IsEnabled = true;

            Button C11 = (Button)BoardOfButtons.FindName("A12");
            C11.Opacity = 0;
            C11.IsEnabled = true;

            Button C10 = (Button)BoardOfButtons.FindName("A12");
            C10.Opacity = 0;
            C10.IsEnabled = true;

            Button C9 = (Button)BoardOfButtons.FindName("A12");
            C9.Opacity = 0;
            C9.IsEnabled = true;

            Button C8 = (Button)BoardOfButtons.FindName("A12");
            C8.Opacity = 0;
            C8.IsEnabled = true;

            Button C7 = (Button)BoardOfButtons.FindName("A12");
            C7.Opacity = 0;
            C7.IsEnabled = true;

            Button C6 = (Button)BoardOfButtons.FindName("A12");
            C6.Opacity = 0;
            C6.IsEnabled = true;

            Button C5 = (Button)BoardOfButtons.FindName("A12");
            C5.Opacity = 0;
            C5.IsEnabled = true;

            Button C4 = (Button)BoardOfButtons.FindName("A12");
            C4.Opacity = 0;
            C4.IsEnabled = true;

            Button C3 = (Button)BoardOfButtons.FindName("A12");
            C3.Opacity = 0;
            C3.IsEnabled = true;

            Button C2 = (Button)BoardOfButtons.FindName("A12");
            C2.Opacity = 0;
            C2.IsEnabled = true;

            Button C1 = (Button)BoardOfButtons.FindName("A12");
            C1.Opacity = 0;
            C1.IsEnabled = true;

            Button D19 = (Button)BoardOfButtons.FindName("A12");
            D19.Opacity = 0;
            D19.IsEnabled = true;

            Button D18 = (Button)BoardOfButtons.FindName("A12");
            D18.Opacity = 0;
            D18.IsEnabled = true;

            Button D17 = (Button)BoardOfButtons.FindName("A12");
            D17.Opacity = 0;
            D17.IsEnabled = true;

            Button D16 = (Button)BoardOfButtons.FindName("A12");
            D16.Opacity = 0;
            D16.IsEnabled = true;

            Button D15 = (Button)BoardOfButtons.FindName("A12");
            D15.Opacity = 0;
            D15.IsEnabled = true;

            Button D14 = (Button)BoardOfButtons.FindName("A12");
            D14.Opacity = 0;
            D14.IsEnabled = true;

            Button D13 = (Button)BoardOfButtons.FindName("A12");
            D13.Opacity = 0;
            D13.IsEnabled = true;

            Button D12 = (Button)BoardOfButtons.FindName("A12");
            D12.Opacity = 0;
            D12.IsEnabled = true;

            Button D11 = (Button)BoardOfButtons.FindName("A12");
            D11.Opacity = 0;
            D11.IsEnabled = true;

            Button D10 = (Button)BoardOfButtons.FindName("A12");
            D10.Opacity = 0;
            D10.IsEnabled = true;

            Button D9 = (Button)BoardOfButtons.FindName("A12");
            D9.Opacity = 0;
            D9.IsEnabled = true;

            Button D8 = (Button)BoardOfButtons.FindName("A12");
            D8.Opacity = 0;
            D8.IsEnabled = true;

            Button D7 = (Button)BoardOfButtons.FindName("A12");
            D7.Opacity = 0;
            D7.IsEnabled = true;

            Button D6 = (Button)BoardOfButtons.FindName("A12");
            D6.Opacity = 0;
            D6.IsEnabled = true;

            Button D5 = (Button)BoardOfButtons.FindName("A12");
            D5.Opacity = 0;
            D5.IsEnabled = true;

            Button D4 = (Button)BoardOfButtons.FindName("A12");
            D4.Opacity = 0;
            D4.IsEnabled = true;

            Button D3 = (Button)BoardOfButtons.FindName("A12");
            D3.Opacity = 0;
            D3.IsEnabled = true;

            Button D2 = (Button)BoardOfButtons.FindName("A12");
            D2.Opacity = 0;
            D2.IsEnabled = true;

            Button D1 = (Button)BoardOfButtons.FindName("A12");
            D1.Opacity = 0;
            D1.IsEnabled = true;

            Button E19 = (Button)BoardOfButtons.FindName("A12");
            E19.Opacity = 0;
            E19.IsEnabled = true;

            Button E18 = (Button)BoardOfButtons.FindName("A12");
            E18.Opacity = 0;
            E18.IsEnabled = true;

            Button E17 = (Button)BoardOfButtons.FindName("A12");
            E17.Opacity = 0;
            E17.IsEnabled = true;

            Button E16 = (Button)BoardOfButtons.FindName("A12");
            E16.Opacity = 0;
            E16.IsEnabled = true;

            Button E15 = (Button)BoardOfButtons.FindName("A12");
            E15.Opacity = 0;
            E15.IsEnabled = true;

            Button E14 = (Button)BoardOfButtons.FindName("A12");
            E14.Opacity = 0;
            E14.IsEnabled = true;

            Button E13 = (Button)BoardOfButtons.FindName("A12");
            E13.Opacity = 0;
            E13.IsEnabled = true;

            Button E12 = (Button)BoardOfButtons.FindName("A12");
            E12.Opacity = 0;
            E12.IsEnabled = true;

            Button E11 = (Button)BoardOfButtons.FindName("A12");
            E11.Opacity = 0;
            E11.IsEnabled = true;

            Button E10 = (Button)BoardOfButtons.FindName("A12");
            E10.Opacity = 0;
            E10.IsEnabled = true;

            Button E9 = (Button)BoardOfButtons.FindName("A12");
            E9.Opacity = 0;
            E9.IsEnabled = true;

            Button E8 = (Button)BoardOfButtons.FindName("A12");
            E8.Opacity = 0;
            E8.IsEnabled = true;

            Button E7 = (Button)BoardOfButtons.FindName("A12");
            E7.Opacity = 0;
            E7.IsEnabled = true;

            Button E6 = (Button)BoardOfButtons.FindName("A12");
            E6.Opacity = 0;
            E6.IsEnabled = true;

            Button E5 = (Button)BoardOfButtons.FindName("A12");
            E5.Opacity = 0;
            E5.IsEnabled = true;

            Button E4 = (Button)BoardOfButtons.FindName("A12");
            E4.Opacity = 0;
            E4.IsEnabled = true;

            Button E3 = (Button)BoardOfButtons.FindName("A12");
            E3.Opacity = 0;
            E3.IsEnabled = true;

            Button E2 = (Button)BoardOfButtons.FindName("A12");
            E2.Opacity = 0;
            E2.IsEnabled = true;

            Button E1 = (Button)BoardOfButtons.FindName("A12");
            E1.Opacity = 0;
            E1.IsEnabled = true;

            Button F19 = (Button)BoardOfButtons.FindName("A12");
            F19.Opacity = 0;
            F19.IsEnabled = true;

            Button F18 = (Button)BoardOfButtons.FindName("A12");
            F18.Opacity = 0;
            F18.IsEnabled = true;

            Button F17 = (Button)BoardOfButtons.FindName("A12");
            F17.Opacity = 0;
            F17.IsEnabled = true;

            Button F16 = (Button)BoardOfButtons.FindName("A12");
            F16.Opacity = 0;
            F16.IsEnabled = true;

            Button F15 = (Button)BoardOfButtons.FindName("A12");
            F15.Opacity = 0;
            F15.IsEnabled = true;

            Button F14 = (Button)BoardOfButtons.FindName("A12");
            F14.Opacity = 0;
            F14.IsEnabled = true;

            Button F13 = (Button)BoardOfButtons.FindName("A12");
            F13.Opacity = 0;
            F13.IsEnabled = true;

            Button F12 = (Button)BoardOfButtons.FindName("A12");
            F12.Opacity = 0;
            F12.IsEnabled = true;

            Button F11 = (Button)BoardOfButtons.FindName("A12");
            F11.Opacity = 0;
            F11.IsEnabled = true;

            Button F10 = (Button)BoardOfButtons.FindName("A12");
            F10.Opacity = 0;
            F10.IsEnabled = true;

            Button F9 = (Button)BoardOfButtons.FindName("A12");
            F9.Opacity = 0;
            F9.IsEnabled = true;

            Button F8 = (Button)BoardOfButtons.FindName("A12");
            F8.Opacity = 0;
            F8.IsEnabled = true;

            Button F7 = (Button)BoardOfButtons.FindName("A12");
            F7.Opacity = 0;
            F7.IsEnabled = true;

            Button F6 = (Button)BoardOfButtons.FindName("A12");
            F6.Opacity = 0;
            F6.IsEnabled = true;

            Button F5 = (Button)BoardOfButtons.FindName("A12");
            F5.Opacity = 0;
            F5.IsEnabled = true;

            Button F4 = (Button)BoardOfButtons.FindName("A12");
            F4.Opacity = 0;
            F4.IsEnabled = true;

            Button F3 = (Button)BoardOfButtons.FindName("A12");
            F3.Opacity = 0;
            F3.IsEnabled = true;

            Button F2 = (Button)BoardOfButtons.FindName("A12");
            F2.Opacity = 0;
            F2.IsEnabled = true;

            Button F1 = (Button)BoardOfButtons.FindName("A12");
            F1.Opacity = 0;
            F1.IsEnabled = true;

            Button G19 = (Button)BoardOfButtons.FindName("A12");
            G19.Opacity = 0;
            G19.IsEnabled = true;

            Button G18 = (Button)BoardOfButtons.FindName("A12");
            G18.Opacity = 0;
            G18.IsEnabled = true;

            Button G17 = (Button)BoardOfButtons.FindName("A12");
            G17.Opacity = 0;
            G17.IsEnabled = true;

            Button G16 = (Button)BoardOfButtons.FindName("A12");
            G16.Opacity = 0;
            G16.IsEnabled = true;

            Button G15 = (Button)BoardOfButtons.FindName("A12");
            G15.Opacity = 0;
            G15.IsEnabled = true;

            Button G14 = (Button)BoardOfButtons.FindName("A12");
            G14.Opacity = 0;
            G14.IsEnabled = true;

            Button G13 = (Button)BoardOfButtons.FindName("A12");
            G13.Opacity = 0;
            G13.IsEnabled = true;

            Button G12 = (Button)BoardOfButtons.FindName("A12");
            G12.Opacity = 0;
            G12.IsEnabled = true;

            Button G11 = (Button)BoardOfButtons.FindName("A12");
            G11.Opacity = 0;
            G11.IsEnabled = true;

            Button G10 = (Button)BoardOfButtons.FindName("A12");
            G10.Opacity = 0;
            G10.IsEnabled = true;

            Button G9 = (Button)BoardOfButtons.FindName("A12");
            G9.Opacity = 0;
            G9.IsEnabled = true;

            Button G8 = (Button)BoardOfButtons.FindName("A12");
            G8.Opacity = 0;
            G8.IsEnabled = true;

            Button G7 = (Button)BoardOfButtons.FindName("A12");
            G7.Opacity = 0;
            G7.IsEnabled = true;

            Button G6 = (Button)BoardOfButtons.FindName("A12");
            G6.Opacity = 0;
            G6.IsEnabled = true;

            Button G5 = (Button)BoardOfButtons.FindName("A12");
            G5.Opacity = 0;
            G5.IsEnabled = true;

            Button G4 = (Button)BoardOfButtons.FindName("A12");
            G4.Opacity = 0;
            G4.IsEnabled = true;

            Button G3 = (Button)BoardOfButtons.FindName("A12");
            G3.Opacity = 0;
            G3.IsEnabled = true;

            Button G2 = (Button)BoardOfButtons.FindName("A12");
            G2.Opacity = 0;
            G2.IsEnabled = true;

            Button G1 = (Button)BoardOfButtons.FindName("A12");
            G1.Opacity = 0;
            G1.IsEnabled = true;

            Button H19 = (Button)BoardOfButtons.FindName("A12");
            H19.Opacity = 0;
            H19.IsEnabled = true;

            Button H18 = (Button)BoardOfButtons.FindName("A12");
            H18.Opacity = 0;
            H18.IsEnabled = true;

            Button H17 = (Button)BoardOfButtons.FindName("A12");
            H17.Opacity = 0;
            H17.IsEnabled = true;

            Button H16 = (Button)BoardOfButtons.FindName("A12");
            H16.Opacity = 0;
            H16.IsEnabled = true;

            Button H15 = (Button)BoardOfButtons.FindName("A12");
            H15.Opacity = 0;
            H15.IsEnabled = true;

            Button H14 = (Button)BoardOfButtons.FindName("A12");
            H14.Opacity = 0;
            H14.IsEnabled = true;

            Button H13 = (Button)BoardOfButtons.FindName("A12");
            H13.Opacity = 0;
            H13.IsEnabled = true;

            Button H12 = (Button)BoardOfButtons.FindName("A12");
            H12.Opacity = 0;
            H12.IsEnabled = true;

            Button H11 = (Button)BoardOfButtons.FindName("A12");
            H11.Opacity = 0;
            H11.IsEnabled = true;

            Button H10 = (Button)BoardOfButtons.FindName("A12");
            H10.Opacity = 0;
            H10.IsEnabled = true;

            Button H9 = (Button)BoardOfButtons.FindName("A12");
            H9.Opacity = 0;
            H9.IsEnabled = true;

            Button H8 = (Button)BoardOfButtons.FindName("A12");
            H8.Opacity = 0;
            H8.IsEnabled = true;

            Button H7 = (Button)BoardOfButtons.FindName("A12");
            H7.Opacity = 0;
            H7.IsEnabled = true;

            Button H6 = (Button)BoardOfButtons.FindName("A12");
            H6.Opacity = 0;
            H6.IsEnabled = true;

            Button H5 = (Button)BoardOfButtons.FindName("A12");
            H5.Opacity = 0;
            H5.IsEnabled = true;

            Button H4 = (Button)BoardOfButtons.FindName("A12");
            H4.Opacity = 0;
            H4.IsEnabled = true;

            Button H3 = (Button)BoardOfButtons.FindName("A12");
            H3.Opacity = 0;
            H3.IsEnabled = true;

            Button H2 = (Button)BoardOfButtons.FindName("A12");
            H2.Opacity = 0;
            H2.IsEnabled = true;

            Button H1 = (Button)BoardOfButtons.FindName("A12");
            H1.Opacity = 0;
            H1.IsEnabled = true;

            Button I19 = (Button)BoardOfButtons.FindName("A12");
            I19.Opacity = 0;
            I19.IsEnabled = true;

            Button I18 = (Button)BoardOfButtons.FindName("A12");
            I18.Opacity = 0;
            I18.IsEnabled = true;

            Button I17 = (Button)BoardOfButtons.FindName("A12");
            I17.Opacity = 0;
            I17.IsEnabled = true;

            Button I16 = (Button)BoardOfButtons.FindName("A12");
            I16.Opacity = 0;
            I16.IsEnabled = true;

            Button I15 = (Button)BoardOfButtons.FindName("A12");
            I15.Opacity = 0;
            I15.IsEnabled = true;

            Button I14 = (Button)BoardOfButtons.FindName("A12");
            I14.Opacity = 0;
            I14.IsEnabled = true;

            Button I13 = (Button)BoardOfButtons.FindName("A12");
            I13.Opacity = 0;
            I13.IsEnabled = true;

            Button I12 = (Button)BoardOfButtons.FindName("A12");
            I12.Opacity = 0;
            I12.IsEnabled = true;

            Button I11 = (Button)BoardOfButtons.FindName("A12");
            I11.Opacity = 0;
            I11.IsEnabled = true;

            Button I10 = (Button)BoardOfButtons.FindName("A12");
            I10.Opacity = 0;
            I10.IsEnabled = true;

            Button I9 = (Button)BoardOfButtons.FindName("A12");
            I9.Opacity = 0;
            I9.IsEnabled = true;

            Button I8 = (Button)BoardOfButtons.FindName("A12");
            I8.Opacity = 0;
            I8.IsEnabled = true;

            Button I7 = (Button)BoardOfButtons.FindName("A12");
            I7.Opacity = 0;
            I7.IsEnabled = true;

            Button I6 = (Button)BoardOfButtons.FindName("A12");
            I6.Opacity = 0;
            I6.IsEnabled = true;

            Button I5 = (Button)BoardOfButtons.FindName("A12");
            I5.Opacity = 0;
            I5.IsEnabled = true;

            Button I4 = (Button)BoardOfButtons.FindName("A12");
            I4.Opacity = 0;
            I4.IsEnabled = true;

            Button I3 = (Button)BoardOfButtons.FindName("A12");
            I3.Opacity = 0;
            I3.IsEnabled = true;

            Button I2 = (Button)BoardOfButtons.FindName("A12");
            I2.Opacity = 0;
            I2.IsEnabled = true;

            Button I1 = (Button)BoardOfButtons.FindName("A12");
            I1.Opacity = 0;
            I1.IsEnabled = true;

            Button J19 = (Button)BoardOfButtons.FindName("A12");
            J19.Opacity = 0;
            J19.IsEnabled = true;

            Button J18 = (Button)BoardOfButtons.FindName("A12");
            J18.Opacity = 0;
            J18.IsEnabled = true;

            Button J17 = (Button)BoardOfButtons.FindName("A12");
            J17.Opacity = 0;
            J17.IsEnabled = true;

            Button J16 = (Button)BoardOfButtons.FindName("A12");
            J16.Opacity = 0;
            J16.IsEnabled = true;

            Button J15 = (Button)BoardOfButtons.FindName("A12");
            J15.Opacity = 0;
            J15.IsEnabled = true;

            Button J14 = (Button)BoardOfButtons.FindName("A12");
            J14.Opacity = 0;
            J14.IsEnabled = true;

            Button J13 = (Button)BoardOfButtons.FindName("A12");
            J13.Opacity = 0;
            J13.IsEnabled = true;

            Button J12 = (Button)BoardOfButtons.FindName("A12");
            J12.Opacity = 0;
            J12.IsEnabled = true;

            Button J11 = (Button)BoardOfButtons.FindName("A12");
            J11.Opacity = 0;
            J11.IsEnabled = true;

            Button J10 = (Button)BoardOfButtons.FindName("A12");
            J10.Opacity = 0;
            J10.IsEnabled = true;

            Button J9 = (Button)BoardOfButtons.FindName("A12");
            J9.Opacity = 0;
            J9.IsEnabled = true;

            Button J8 = (Button)BoardOfButtons.FindName("A12");
            J8.Opacity = 0;
            J8.IsEnabled = true;

            Button J7 = (Button)BoardOfButtons.FindName("A12");
            J7.Opacity = 0;
            J7.IsEnabled = true;

            Button J6 = (Button)BoardOfButtons.FindName("A12");
            J6.Opacity = 0;
            J6.IsEnabled = true;

            Button J5 = (Button)BoardOfButtons.FindName("A12");
            J5.Opacity = 0;
            J5.IsEnabled = true;

            Button J4 = (Button)BoardOfButtons.FindName("A12");
            J4.Opacity = 0;
            J4.IsEnabled = true;

            Button J3 = (Button)BoardOfButtons.FindName("A12");
            J3.Opacity = 0;
            J3.IsEnabled = true;

            Button J2 = (Button)BoardOfButtons.FindName("A12");
            J2.Opacity = 0;
            J2.IsEnabled = true;

            Button J1 = (Button)BoardOfButtons.FindName("A12");
            J1.Opacity = 0;
            J1.IsEnabled = true;

            Button K19 = (Button)BoardOfButtons.FindName("A12");
            K19.Opacity = 0;
            K19.IsEnabled = true;

            Button K18 = (Button)BoardOfButtons.FindName("A12");
            K18.Opacity = 0;
            K18.IsEnabled = true;

            Button K17 = (Button)BoardOfButtons.FindName("A12");
            K17.Opacity = 0;
            K17.IsEnabled = true;

            Button K16 = (Button)BoardOfButtons.FindName("A12");
            K16.Opacity = 0;
            K16.IsEnabled = true;

            Button K15 = (Button)BoardOfButtons.FindName("A12");
            K15.Opacity = 0;
            K15.IsEnabled = true;

            Button K14 = (Button)BoardOfButtons.FindName("A12");
            K14.Opacity = 0;
            K14.IsEnabled = true;

            Button K13 = (Button)BoardOfButtons.FindName("A12");
            K13.Opacity = 0;
            K13.IsEnabled = true;

            Button K12 = (Button)BoardOfButtons.FindName("A12");
            K12.Opacity = 0;
            K12.IsEnabled = true;

            Button K11 = (Button)BoardOfButtons.FindName("A12");
            K11.Opacity = 0;
            K11.IsEnabled = true;

            Button K10 = (Button)BoardOfButtons.FindName("A12");
            K10.Opacity = 0;
            K10.IsEnabled = true;

            Button K9 = (Button)BoardOfButtons.FindName("A12");
            K9.Opacity = 0;
            K9.IsEnabled = true;

            Button K8 = (Button)BoardOfButtons.FindName("A12");
            K8.Opacity = 0;
            K8.IsEnabled = true;

            Button K7 = (Button)BoardOfButtons.FindName("A12");
            K7.Opacity = 0;
            K7.IsEnabled = true;

            Button K6 = (Button)BoardOfButtons.FindName("A12");
            K6.Opacity = 0;
            K6.IsEnabled = true;

            Button K5 = (Button)BoardOfButtons.FindName("A12");
            K5.Opacity = 0;
            K5.IsEnabled = true;

            Button K4 = (Button)BoardOfButtons.FindName("A12");
            K4.Opacity = 0;
            K4.IsEnabled = true;

            Button K3 = (Button)BoardOfButtons.FindName("A12");
            K3.Opacity = 0;
            K3.IsEnabled = true;

            Button K2 = (Button)BoardOfButtons.FindName("A12");
            K2.Opacity = 0;
            K2.IsEnabled = true;

            Button K1 = (Button)BoardOfButtons.FindName("A12");
            K1.Opacity = 0;
            K1.IsEnabled = true;

            Button L19 = (Button)BoardOfButtons.FindName("A12");
            L19.Opacity = 0;
            L19.IsEnabled = true;

            Button L18 = (Button)BoardOfButtons.FindName("A12");
            L18.Opacity = 0;
            L18.IsEnabled = true;

            Button L17 = (Button)BoardOfButtons.FindName("A12");
            L17.Opacity = 0;
            L17.IsEnabled = true;

            Button L16 = (Button)BoardOfButtons.FindName("A12");
            L16.Opacity = 0;
            L16.IsEnabled = true;

            Button L15 = (Button)BoardOfButtons.FindName("A12");
            L15.Opacity = 0;
            L15.IsEnabled = true;

            Button L14 = (Button)BoardOfButtons.FindName("A12");
            L14.Opacity = 0;
            L14.IsEnabled = true;

            Button L13 = (Button)BoardOfButtons.FindName("A12");
            L13.Opacity = 0;
            L13.IsEnabled = true;

            Button L12 = (Button)BoardOfButtons.FindName("A12");
            L12.Opacity = 0;
            L12.IsEnabled = true;

            Button L11 = (Button)BoardOfButtons.FindName("A12");
            L11.Opacity = 0;
            L11.IsEnabled = true;

            Button L10 = (Button)BoardOfButtons.FindName("A12");
            L10.Opacity = 0;
            L10.IsEnabled = true;

            Button L9 = (Button)BoardOfButtons.FindName("A12");
            L9.Opacity = 0;
            L9.IsEnabled = true;

            Button L8 = (Button)BoardOfButtons.FindName("A12");
            L8.Opacity = 0;
            L8.IsEnabled = true;

            Button L7 = (Button)BoardOfButtons.FindName("A12");
            L7.Opacity = 0;
            L7.IsEnabled = true;

            Button L6 = (Button)BoardOfButtons.FindName("A12");
            L6.Opacity = 0;
            L6.IsEnabled = true;

            Button L5 = (Button)BoardOfButtons.FindName("A12");
            L5.Opacity = 0;
            L5.IsEnabled = true;

            Button L4 = (Button)BoardOfButtons.FindName("A12");
            L4.Opacity = 0;
            L4.IsEnabled = true;

            Button L3 = (Button)BoardOfButtons.FindName("A12");
            L3.Opacity = 0;
            L3.IsEnabled = true;

            Button L2 = (Button)BoardOfButtons.FindName("A12");
            L2.Opacity = 0;
            L2.IsEnabled = true;

            Button L1 = (Button)BoardOfButtons.FindName("A12");
            L1.Opacity = 0;
            L1.IsEnabled = true;

            Button M19 = (Button)BoardOfButtons.FindName("A12");
            M19.Opacity = 0;
            M19.IsEnabled = true;

            Button M18 = (Button)BoardOfButtons.FindName("A12");
            M18.Opacity = 0;
            M18.IsEnabled = true;

            Button M17 = (Button)BoardOfButtons.FindName("A12");
            M17.Opacity = 0;
            M17.IsEnabled = true;

            Button M16 = (Button)BoardOfButtons.FindName("A12");
            M16.Opacity = 0;
            M16.IsEnabled = true;

            Button M15 = (Button)BoardOfButtons.FindName("A12");
            M15.Opacity = 0;
            M15.IsEnabled = true;

            Button M14 = (Button)BoardOfButtons.FindName("A12");
            M14.Opacity = 0;
            M14.IsEnabled = true;

            Button M13 = (Button)BoardOfButtons.FindName("A12");
            M13.Opacity = 0;
            M13.IsEnabled = true;

            Button M12 = (Button)BoardOfButtons.FindName("A12");
            M12.Opacity = 0;
            M12.IsEnabled = true;

            Button M11 = (Button)BoardOfButtons.FindName("A12");
            M11.Opacity = 0;
            M11.IsEnabled = true;

            Button M10 = (Button)BoardOfButtons.FindName("A12");
            M10.Opacity = 0;
            M10.IsEnabled = true;

            Button M9 = (Button)BoardOfButtons.FindName("A12");
            M9.Opacity = 0;
            M9.IsEnabled = true;

            Button M8 = (Button)BoardOfButtons.FindName("A12");
            M8.Opacity = 0;
            M8.IsEnabled = true;

            Button M7 = (Button)BoardOfButtons.FindName("A12");
            M7.Opacity = 0;
            M7.IsEnabled = true;

            Button M6 = (Button)BoardOfButtons.FindName("A12");
            M6.Opacity = 0;
            M6.IsEnabled = true;

            Button M5 = (Button)BoardOfButtons.FindName("A12");
            M5.Opacity = 0;
            M5.IsEnabled = true;

            Button M4 = (Button)BoardOfButtons.FindName("A12");
            M4.Opacity = 0;
            M4.IsEnabled = true;

            Button M3 = (Button)BoardOfButtons.FindName("A12");
            M3.Opacity = 0;
            M3.IsEnabled = true;

            Button M2 = (Button)BoardOfButtons.FindName("A12");
            M2.Opacity = 0;
            M2.IsEnabled = true;

            Button M1 = (Button)BoardOfButtons.FindName("A12");
            M1.Opacity = 0;
            M1.IsEnabled = true;

            Button N19 = (Button)BoardOfButtons.FindName("A12");
            N19.Opacity = 0;
            N19.IsEnabled = true;

            Button N18 = (Button)BoardOfButtons.FindName("A12");
            N18.Opacity = 0;
            N18.IsEnabled = true;

            Button N17 = (Button)BoardOfButtons.FindName("A12");
            N17.Opacity = 0;
            N17.IsEnabled = true;

            Button N16 = (Button)BoardOfButtons.FindName("A12");
            N16.Opacity = 0;
            N16.IsEnabled = true;

            Button N15 = (Button)BoardOfButtons.FindName("A12");
            N15.Opacity = 0;
            N15.IsEnabled = true;

            Button N14 = (Button)BoardOfButtons.FindName("A12");
            N14.Opacity = 0;
            N14.IsEnabled = true;

            Button N13 = (Button)BoardOfButtons.FindName("A12");
            N13.Opacity = 0;
            N13.IsEnabled = true;

            Button N12 = (Button)BoardOfButtons.FindName("A12");
            N12.Opacity = 0;
            N12.IsEnabled = true;

            Button N11 = (Button)BoardOfButtons.FindName("A12");
            N11.Opacity = 0;
            N11.IsEnabled = true;

            Button N10 = (Button)BoardOfButtons.FindName("A12");
            N10.Opacity = 0;
            N10.IsEnabled = true;

            Button N9 = (Button)BoardOfButtons.FindName("A12");
            N9.Opacity = 0;
            N9.IsEnabled = true;

            Button N8 = (Button)BoardOfButtons.FindName("A12");
            N8.Opacity = 0;
            N8.IsEnabled = true;

            Button N7 = (Button)BoardOfButtons.FindName("A12");
            N7.Opacity = 0;
            N7.IsEnabled = true;

            Button N6 = (Button)BoardOfButtons.FindName("A12");
            N6.Opacity = 0;
            N6.IsEnabled = true;

            Button N5 = (Button)BoardOfButtons.FindName("A12");
            N5.Opacity = 0;
            N5.IsEnabled = true;

            Button N4 = (Button)BoardOfButtons.FindName("A12");
            N4.Opacity = 0;
            N4.IsEnabled = true;

            Button N3 = (Button)BoardOfButtons.FindName("A12");
            N3.Opacity = 0;
            N3.IsEnabled = true;

            Button N2 = (Button)BoardOfButtons.FindName("A12");
            N2.Opacity = 0;
            N2.IsEnabled = true;

            Button N1 = (Button)BoardOfButtons.FindName("A12");
            N1.Opacity = 0;
            N1.IsEnabled = true;

            Button O19 = (Button)BoardOfButtons.FindName("A12");
            O19.Opacity = 0;
            O19.IsEnabled = true;

            Button O18 = (Button)BoardOfButtons.FindName("A12");
            O18.Opacity = 0;
            O18.IsEnabled = true;

            Button O17 = (Button)BoardOfButtons.FindName("A12");
            O17.Opacity = 0;
            O17.IsEnabled = true;

            Button O16 = (Button)BoardOfButtons.FindName("A12");
            O16.Opacity = 0;
            O16.IsEnabled = true;

            Button O15 = (Button)BoardOfButtons.FindName("A12");
            O15.Opacity = 0;
            O15.IsEnabled = true;

            Button O14 = (Button)BoardOfButtons.FindName("A12");
            O14.Opacity = 0;
            O14.IsEnabled = true;

            Button O13 = (Button)BoardOfButtons.FindName("A12");
            O13.Opacity = 0;
            O13.IsEnabled = true;

            Button O12 = (Button)BoardOfButtons.FindName("A12");
            O12.Opacity = 0;
            O12.IsEnabled = true;

            Button O11 = (Button)BoardOfButtons.FindName("A12");
            O11.Opacity = 0;
            O11.IsEnabled = true;

            Button O10 = (Button)BoardOfButtons.FindName("A12");
            O10.Opacity = 0;
            O10.IsEnabled = true;

            Button O9 = (Button)BoardOfButtons.FindName("A12");
            O9.Opacity = 0;
            O9.IsEnabled = true;

            Button O8 = (Button)BoardOfButtons.FindName("A12");
            O8.Opacity = 0;
            O8.IsEnabled = true;

            Button O7 = (Button)BoardOfButtons.FindName("A12");
            O7.Opacity = 0;
            O7.IsEnabled = true;

            Button O6 = (Button)BoardOfButtons.FindName("A12");
            O6.Opacity = 0;
            O6.IsEnabled = true;

            Button O5 = (Button)BoardOfButtons.FindName("A12");
            O5.Opacity = 0;
            O5.IsEnabled = true;

            Button O4 = (Button)BoardOfButtons.FindName("A12");
            O4.Opacity = 0;
            O4.IsEnabled = true;

            Button O3 = (Button)BoardOfButtons.FindName("A12");
            O3.Opacity = 0;
            O3.IsEnabled = true;

            Button O2 = (Button)BoardOfButtons.FindName("A12");
            O2.Opacity = 0;
            O2.IsEnabled = true;

            Button O1 = (Button)BoardOfButtons.FindName("A12");
            O1.Opacity = 0;
            O1.IsEnabled = true;

            Button P19 = (Button)BoardOfButtons.FindName("A12");
            P19.Opacity = 0;
            P19.IsEnabled = true;

            Button P18 = (Button)BoardOfButtons.FindName("A12");
            P18.Opacity = 0;
            P18.IsEnabled = true;

            Button P17 = (Button)BoardOfButtons.FindName("A12");
            P17.Opacity = 0;
            P17.IsEnabled = true;

            Button P16 = (Button)BoardOfButtons.FindName("A12");
            P16.Opacity = 0;
            P16.IsEnabled = true;

            Button P15 = (Button)BoardOfButtons.FindName("A12");
            P15.Opacity = 0;
            P15.IsEnabled = true;

            Button P14 = (Button)BoardOfButtons.FindName("A12");
            P14.Opacity = 0;
            P14.IsEnabled = true;

            Button P13 = (Button)BoardOfButtons.FindName("A12");
            P13.Opacity = 0;
            P13.IsEnabled = true;

            Button P12 = (Button)BoardOfButtons.FindName("A12");
            P12.Opacity = 0;
            P12.IsEnabled = true;

            Button P11 = (Button)BoardOfButtons.FindName("A12");
            P11.Opacity = 0;
            P11.IsEnabled = true;

            Button P10 = (Button)BoardOfButtons.FindName("A12");
            P10.Opacity = 0;
            P10.IsEnabled = true;

            Button P9 = (Button)BoardOfButtons.FindName("A12");
            P9.Opacity = 0;
            P9.IsEnabled = true;

            Button P8 = (Button)BoardOfButtons.FindName("A12");
            P8.Opacity = 0;
            P8.IsEnabled = true;

            Button P7 = (Button)BoardOfButtons.FindName("A12");
            P7.Opacity = 0;
            P7.IsEnabled = true;

            Button P6 = (Button)BoardOfButtons.FindName("A12");
            P6.Opacity = 0;
            P6.IsEnabled = true;

            Button P5 = (Button)BoardOfButtons.FindName("A12");
            P5.Opacity = 0;
            P5.IsEnabled = true;

            Button P4 = (Button)BoardOfButtons.FindName("A12");
            P4.Opacity = 0;
            P4.IsEnabled = true;

            Button P3 = (Button)BoardOfButtons.FindName("A12");
            P3.Opacity = 0;
            P3.IsEnabled = true;

            Button P2 = (Button)BoardOfButtons.FindName("A12");
            P2.Opacity = 0;
            P2.IsEnabled = true;

            Button P1 = (Button)BoardOfButtons.FindName("A12");
            P1.Opacity = 0;
            P1.IsEnabled = true;

            Button Q19 = (Button)BoardOfButtons.FindName("A12");
            Q19.Opacity = 0;
            Q19.IsEnabled = true;

            Button Q18 = (Button)BoardOfButtons.FindName("A12");
            Q18.Opacity = 0;
            Q18.IsEnabled = true;

            Button Q17 = (Button)BoardOfButtons.FindName("A12");
            Q17.Opacity = 0;
            Q17.IsEnabled = true;

            Button Q16 = (Button)BoardOfButtons.FindName("A12");
            Q16.Opacity = 0;
            Q16.IsEnabled = true;

            Button Q15 = (Button)BoardOfButtons.FindName("A12");
            Q15.Opacity = 0;
            Q15.IsEnabled = true;

            Button Q14 = (Button)BoardOfButtons.FindName("A12");
            Q14.Opacity = 0;
            Q14.IsEnabled = true;

            Button Q13 = (Button)BoardOfButtons.FindName("A12");
            Q13.Opacity = 0;
            Q13.IsEnabled = true;

            Button Q12 = (Button)BoardOfButtons.FindName("A12");
            Q12.Opacity = 0;
            Q12.IsEnabled = true;

            Button Q11 = (Button)BoardOfButtons.FindName("A12");
            Q11.Opacity = 0;
            Q11.IsEnabled = true;

            Button Q10 = (Button)BoardOfButtons.FindName("A12");
            Q10.Opacity = 0;
            Q10.IsEnabled = true;

            Button Q9 = (Button)BoardOfButtons.FindName("A12");
            Q9.Opacity = 0;
            Q9.IsEnabled = true;

            Button Q8 = (Button)BoardOfButtons.FindName("A12");
            Q8.Opacity = 0;
            Q8.IsEnabled = true;

            Button Q7 = (Button)BoardOfButtons.FindName("A12");
            Q7.Opacity = 0;
            Q7.IsEnabled = true;

            Button Q6 = (Button)BoardOfButtons.FindName("A12");
            Q6.Opacity = 0;
            Q6.IsEnabled = true;

            Button Q5 = (Button)BoardOfButtons.FindName("A12");
            Q5.Opacity = 0;
            Q5.IsEnabled = true;

            Button Q4 = (Button)BoardOfButtons.FindName("A12");
            Q4.Opacity = 0;
            Q4.IsEnabled = true;

            Button Q3 = (Button)BoardOfButtons.FindName("A12");
            Q3.Opacity = 0;
            Q3.IsEnabled = true;

            Button Q2 = (Button)BoardOfButtons.FindName("A12");
            Q2.Opacity = 0;
            Q2.IsEnabled = true;

            Button Q1 = (Button)BoardOfButtons.FindName("A12");
            Q1.Opacity = 0;
            Q1.IsEnabled = true;

            Button R19 = (Button)BoardOfButtons.FindName("A12");
            R19.Opacity = 0;
            R19.IsEnabled = true;

            Button R18 = (Button)BoardOfButtons.FindName("A12");
            R18.Opacity = 0;
            R18.IsEnabled = true;

            Button R17 = (Button)BoardOfButtons.FindName("A12");
            R17.Opacity = 0;
            R17.IsEnabled = true;

            Button R16 = (Button)BoardOfButtons.FindName("A12");
            R16.Opacity = 0;
            R16.IsEnabled = true;

            Button R15 = (Button)BoardOfButtons.FindName("A12");
            R15.Opacity = 0;
            R15.IsEnabled = true;

            Button R14 = (Button)BoardOfButtons.FindName("A12");
            R14.Opacity = 0;
            R14.IsEnabled = true;

            Button R13 = (Button)BoardOfButtons.FindName("A12");
            R13.Opacity = 0;
            R13.IsEnabled = true;

            Button R12 = (Button)BoardOfButtons.FindName("A12");
            R12.Opacity = 0;
            R12.IsEnabled = true;

            Button R11 = (Button)BoardOfButtons.FindName("A12");
            R11.Opacity = 0;
            R11.IsEnabled = true;

            Button R10 = (Button)BoardOfButtons.FindName("A12");
            R10.Opacity = 0;
            R10.IsEnabled = true;

            Button R9 = (Button)BoardOfButtons.FindName("A12");
            R9.Opacity = 0;
            R9.IsEnabled = true;

            Button R8 = (Button)BoardOfButtons.FindName("A12");
            R8.Opacity = 0;
            R8.IsEnabled = true;

            Button R7 = (Button)BoardOfButtons.FindName("A12");
            R7.Opacity = 0;
            R7.IsEnabled = true;

            Button R6 = (Button)BoardOfButtons.FindName("A12");
            R6.Opacity = 0;
            R6.IsEnabled = true;

            Button R5 = (Button)BoardOfButtons.FindName("A12");
            R5.Opacity = 0;
            R5.IsEnabled = true;

            Button R4 = (Button)BoardOfButtons.FindName("A12");
            R4.Opacity = 0;
            R4.IsEnabled = true;

            Button R3 = (Button)BoardOfButtons.FindName("A12");
            R3.Opacity = 0;
            R3.IsEnabled = true;

            Button R2 = (Button)BoardOfButtons.FindName("A12");
            R2.Opacity = 0;
            R2.IsEnabled = true;

            Button R1 = (Button)BoardOfButtons.FindName("A12");
            R1.Opacity = 0;
            R1.IsEnabled = true;

            Button S19 = (Button)BoardOfButtons.FindName("A12");
            S19.Opacity = 0;
            S19.IsEnabled = true;

            Button S18 = (Button)BoardOfButtons.FindName("A12");
            S18.Opacity = 0;
            S18.IsEnabled = true;

            Button S17 = (Button)BoardOfButtons.FindName("A12");
            S17.Opacity = 0;
            S17.IsEnabled = true;

            Button S16 = (Button)BoardOfButtons.FindName("A12");
            S16.Opacity = 0;
            S16.IsEnabled = true;

            Button S15 = (Button)BoardOfButtons.FindName("A12");
            S15.Opacity = 0;
            S15.IsEnabled = true;

            Button S14 = (Button)BoardOfButtons.FindName("A12");
            S14.Opacity = 0;
            S14.IsEnabled = true;

            Button S13 = (Button)BoardOfButtons.FindName("A12");
            S13.Opacity = 0;
            S13.IsEnabled = true;

            Button S12 = (Button)BoardOfButtons.FindName("A12");
            S12.Opacity = 0;
            S12.IsEnabled = true;

            Button S11 = (Button)BoardOfButtons.FindName("A12");
            S11.Opacity = 0;
            S11.IsEnabled = true;

            Button S10 = (Button)BoardOfButtons.FindName("A12");
            S10.Opacity = 0;
            S10.IsEnabled = true;

            Button S9 = (Button)BoardOfButtons.FindName("A12");
            S9.Opacity = 0;
            S9.IsEnabled = true;

            Button S8 = (Button)BoardOfButtons.FindName("A12");
            S8.Opacity = 0;
            S8.IsEnabled = true;

            Button S7 = (Button)BoardOfButtons.FindName("A12");
            S7.Opacity = 0;
            S7.IsEnabled = true;

            Button S6 = (Button)BoardOfButtons.FindName("A12");
            S6.Opacity = 0;
            S6.IsEnabled = true;

            Button S5 = (Button)BoardOfButtons.FindName("A12");
            S5.Opacity = 0;
            S5.IsEnabled = true;

            Button S4 = (Button)BoardOfButtons.FindName("A12");
            S4.Opacity = 0;
            S4.IsEnabled = true;

            Button S3 = (Button)BoardOfButtons.FindName("A12");
            S3.Opacity = 0;
            S3.IsEnabled = true;

            Button S2 = (Button)BoardOfButtons.FindName("A12");
            S2.Opacity = 0;
            S2.IsEnabled = true;

            Button S1 = (Button)BoardOfButtons.FindName("A12");
            S1.Opacity = 0;
            S1.IsEnabled = true;
        }

        private void MainMenu(object sender, RoutedEventArgs e)
        {
            
            MainWindow menu = new MainWindow();
            this.Close();
            menu.Show();
        }

        private void PlacePiece(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            button.Opacity = 100;
            if (playerTurn == GlobalVariables.playerOne.Name)
            {
                //make the image on the button clicked white
                
                button.Background = Brushes.Black;
                playerTurn = GlobalVariables.playerOne.Name;

            }else if (playerTurn == GlobalVariables.playerTwo.Name)
            {
                //make the image on the button clicked black
               button.Background = Brushes.White;
                playerTurn = GlobalVariables.playerOne.Name;
            }

            //making the image seen for the button but they can't click on this button again
            
            button.IsEnabled = false;
            
            //save method to something
            IsMoveValid();
        }

        public bool IsMoveValid()
        {
            //check direction for this button move
            return true;
        }
    }
}
