using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Calculator
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        // Calculator fields //

        // The value currently shown on the calc_output label
        private string currentDisplayedInput = "";

        // Enumeration type for preventing user error
        enum inputTypes { operand, number, leftParen, rightParen};

        // The following values are checked to prevent user error
        // Prevents consecutive operands and decimals
        private inputTypes lastInput;
        // Used to prevent error with parenthesis
        private int rightParenCount = 0;



        // Calculator UI functions //

        // This function will display the currentDisplayedInput field to the calc_output label
        private void update_calc_output_label() {
            calc_output.Text = currentDisplayedInput;
        } 


        // Click event handlers for calculator buttons //

        // Click event handler for the 0 button
        private void num0_btn_Click(object sender, EventArgs e) {

            currentDisplayedInput = currentDisplayedInput + "0";
            update_calc_output_label();
        }

        // Click event handler for the 1 button
        private void num1_btn_Click(object sender, EventArgs e) {
            currentDisplayedInput = currentDisplayedInput + "1";
            update_calc_output_label();
        }

        // Click event handler for the 2 button
        private void num2_btn_Click(object sender, EventArgs e) {
            currentDisplayedInput = currentDisplayedInput + "2";
            update_calc_output_label();
        }

        // Click event handler for the 3 button
        private void num3_btn_Click(object sender, EventArgs e) {
            currentDisplayedInput = currentDisplayedInput + "3";
            update_calc_output_label();
        }

        // Click event handler for the 4 button
        private void num4_btn_Click(object sender, EventArgs e) {
            currentDisplayedInput = currentDisplayedInput + "4";
            update_calc_output_label();
        }

        // Click event handler for the 5 button
        private void num5_btn_Click(object sender, EventArgs e) {
            currentDisplayedInput = currentDisplayedInput + "5";
            update_calc_output_label();
        }

        // Click event handler for the 6 button
        private void num6_btn_Click(object sender, EventArgs e) {
            currentDisplayedInput = currentDisplayedInput + "6";
            update_calc_output_label();
        }

        // Click event handler for the 7 button
        private void num7_btn_Click(object sender, EventArgs e) {
            currentDisplayedInput = currentDisplayedInput + "7";
            update_calc_output_label();
        }

        // Click event handler for the 8 button
        private void num8_btn_Click(object sender, EventArgs e) {
            currentDisplayedInput = currentDisplayedInput + "8";
            update_calc_output_label();
        }

        // Click event handler for the 9 button
        private void num9_btn_Click(object sender, EventArgs e) {
            currentDisplayedInput = currentDisplayedInput + "9";
            update_calc_output_label();
        }

        // Click event handler for the decimal button
        private void decimal_btn_Click(object sender, EventArgs e) {
            currentDisplayedInput = currentDisplayedInput + ".";
            update_calc_output_label();
        }

        // Click event handler for the equals/enter button
        private void equals_btn_Click(object sender, EventArgs e) {

        }

        // Click event handler for the additon button
        private void add_btn_Click(object sender, EventArgs e) {
            currentDisplayedInput = currentDisplayedInput + "+";
            update_calc_output_label();
        }

        // Click event handler for the subtract button
        private void subtract_btn_Click(object sender, EventArgs e) {
            currentDisplayedInput = currentDisplayedInput + "-";
            update_calc_output_label();
        }

        // Click event handler for the multiplication button
        private void times_btn_Click(object sender, EventArgs e) {
            currentDisplayedInput = currentDisplayedInput + "*";
            update_calc_output_label();
        }

        // Click event handler for the division button
        private void division_btn_Click(object sender, EventArgs e) {
            currentDisplayedInput = currentDisplayedInput + "/";
            update_calc_output_label();
        }

        // Click event handler for the modulo button
        private void modulo_btn_Click(object sender, EventArgs e) {
            currentDisplayedInput = currentDisplayedInput + "%";
            update_calc_output_label();
        }

        // Click event handler for the change sign button
        private void change_sign_btn_Click(object sender, EventArgs e) {

        }

        // Click event handler for the clear button
        private void clear_btn_Click(object sender, EventArgs e) {

        }

        // Click event handler for the delete button
        private void delete_btn_Click(object sender, EventArgs e) {

        }

        // Click event handler for the power button
        private void power_bt_Click(object sender, EventArgs e) {
            currentDisplayedInput = currentDisplayedInput + "^";
            update_calc_output_label();
        }

        // Click event handler for the left parenthesis button
        private void left_paren_Click(object sender, EventArgs e) {
            currentDisplayedInput = currentDisplayedInput + "(";
            update_calc_output_label();
        }

        // Click event handler for the right parenthesis button
        private void right_paren_Click(object sender, EventArgs e) {
            currentDisplayedInput = currentDisplayedInput + ")";
            update_calc_output_label();
        }

    }
}
