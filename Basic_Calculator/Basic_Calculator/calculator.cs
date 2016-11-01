﻿using System;
using System.Collections;
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
        enum inputTypes { Operator, Number, LeftParen, RightParen, empty };
        // Error Rules followed //
        // If last input = Number then next input can be anything, if it is a LeftParen then multiplication will be assumed
        // If last input = Operator then next input != Operator
        // If last input = LeftParen then next input != Operator or RightParen
        // If last input = RightParen then next input can be anything, if it is a Number then multiplication will be assumed
        // Prevents consecutive Operators and decimals 
        private inputTypes lastInput = inputTypes.empty;
        // Used to prevent error with parenthesis
        private int LeftParenCount = 0;
        // Used to prevent incorect input of operators
        private Boolean negativeOperatorFlag = false;



        // Input token parser
        private void input_Parsing(String userInput) {
            var delimiters = new[] { '(', ')', '+', '\u2212', '/', '*', '^' };
            ArrayList tokenizedInput = new ArrayList();
            String tempToken = "";
            double number;
            foreach (char c in userInput) {
                if (delimiters.Contains(c)) {

                    if (tempToken.Length > 0) {
                        // This if statement makes sure the token is a number before adding it to the list
                        if (Double.TryParse(tempToken, out number) != true) { incorrect_input(); return; }
                        tokenizedInput.Add(tempToken);
                        tempToken = "";
                    }
                    tokenizedInput.Add(c);
                } else {
                    tempToken += c;
                }
            }
            if (tempToken.Length > 0) {
                // This if statement makes sure the token is a number before adding it to the list
                if (Double.TryParse(tempToken, out number) != true) { incorrect_input(); return; }
                tokenizedInput.Add(tempToken);
            }
            correct_input(tokenizedInput);
            return;
        }

        private double calculate_Value(ArrayList tokenizedInput)
        {
            // Set up two stacks, one for operators like +-/, one for operands like numbers
            Stack<String> operators = new Stack<String> { };
            Stack<String> operands = new Stack<String> { };
            foreach(String s in tokenizedInput) {

            }



            return 2.0;
        }

        // Returns the precedence of the operator
        private int check_Precedence(String op) {
            switch (op)
            {
                case "(":
                    return 4;
                case ")":
                    return 4;
                case "^":
                    return 3;
                case "*":
                    return 2;
                case "/":
                    return 2;
                case "+":
                    return 1;
                case "-":
                    return 1;
                default:
                    incorrect_input();
                    break;
            }





            return 1;
        }

        private void incorrect_input()
        {
            calc_output.Text = "Invalid Input";
        }

        private void correct_input(ArrayList a)
        {
            calc_output.Text = a.ToString();
        }

        // This function will display the currentDisplayedInput field to the calc_output label
        private void update_calc_output_label()
        {
            calc_output.Text = currentDisplayedInput;
        }

        // Click event handlers for calculator buttons //

        // Click event handler for the 0 button
        private void num0_btn_Click(object sender, EventArgs e) {
            currentDisplayedInput = currentDisplayedInput + "0";
            update_calc_output_label();
            lastInput = inputTypes.Number;
        }

        // Click event handler for the 1 button
        private void num1_btn_Click(object sender, EventArgs e) {
            currentDisplayedInput = currentDisplayedInput + "1";
            update_calc_output_label();
            lastInput = inputTypes.Number;
        }

        // Click event handler for the 2 button
        private void num2_btn_Click(object sender, EventArgs e) {
            currentDisplayedInput = currentDisplayedInput + "2";
            update_calc_output_label();
            lastInput = inputTypes.Number;
        }

        // Click event handler for the 3 button
        private void num3_btn_Click(object sender, EventArgs e) {
            currentDisplayedInput = currentDisplayedInput + "3";
            update_calc_output_label();
            lastInput = inputTypes.Number;
        }

        // Click event handler for the 4 button
        private void num4_btn_Click(object sender, EventArgs e) {
            currentDisplayedInput = currentDisplayedInput + "4";
            update_calc_output_label();
            lastInput = inputTypes.Number;
        }

        // Click event handler for the 5 button
        private void num5_btn_Click(object sender, EventArgs e) {
            currentDisplayedInput = currentDisplayedInput + "5";
            update_calc_output_label();
            lastInput = inputTypes.Number;
        }

        // Click event handler for the 6 button
        private void num6_btn_Click(object sender, EventArgs e) {
            currentDisplayedInput = currentDisplayedInput + "6";
            update_calc_output_label();
            lastInput = inputTypes.Number;
        }

        // Click event handler for the 7 button
        private void num7_btn_Click(object sender, EventArgs e) {
            currentDisplayedInput = currentDisplayedInput + "7";
            update_calc_output_label();
            lastInput = inputTypes.Number;
        }

        // Click event handler for the 8 button
        private void num8_btn_Click(object sender, EventArgs e) {
            currentDisplayedInput = currentDisplayedInput + "8";
            update_calc_output_label();
            lastInput = inputTypes.Number;
        }

        // Click event handler for the 9 button
        private void num9_btn_Click(object sender, EventArgs e) {
            currentDisplayedInput = currentDisplayedInput + "9";
            update_calc_output_label();
            lastInput = inputTypes.Number;
        }

        // Click event handler for the decimal button
        private void decimal_btn_Click(object sender, EventArgs e) {
            // Checks to prevent user error
            if (lastInput == inputTypes.Operator || lastInput == inputTypes.LeftParen || lastInput == inputTypes.empty) { return; }
            currentDisplayedInput = currentDisplayedInput + ".";
            update_calc_output_label();
            lastInput = inputTypes.Operator;
        }

        // Click event handler for the equals/enter button
        private void equals_btn_Click(object sender, EventArgs e) {
            input_Parsing(currentDisplayedInput);
            currentDisplayedInput = "";
        }

        // Click event handler for the additon button
        private void add_btn_Click(object sender, EventArgs e) {
            // Checks to prevent user error
            if (lastInput == inputTypes.Operator || lastInput == inputTypes.LeftParen || lastInput == inputTypes.empty) { return; }
            currentDisplayedInput = currentDisplayedInput + "+";
            update_calc_output_label();
            lastInput = inputTypes.Operator;
        }

        // Click event handler for the subtract button
        private void subtract_btn_Click(object sender, EventArgs e) {
            // Checks to prevent user error
            if (lastInput == inputTypes.Operator || lastInput == inputTypes.LeftParen || lastInput == inputTypes.empty) { return; }
            currentDisplayedInput = currentDisplayedInput + "\u2212";
            update_calc_output_label();
            lastInput = inputTypes.Operator;
        }

        // Click event handler for the multiplication button
        private void times_btn_Click(object sender, EventArgs e) {
            // Checks to prevent user error
            if (lastInput == inputTypes.Operator || lastInput == inputTypes.LeftParen || lastInput == inputTypes.empty) { return; }
            currentDisplayedInput = currentDisplayedInput + "*";
            update_calc_output_label();
            lastInput = inputTypes.Operator;
        }

        // Click event handler for the division button
        private void division_btn_Click(object sender, EventArgs e) {
            // Checks to prevent user error
            if (lastInput == inputTypes.Operator || lastInput == inputTypes.LeftParen || lastInput == inputTypes.empty) { return; }
            currentDisplayedInput = currentDisplayedInput + "/";
            update_calc_output_label();
            lastInput = inputTypes.Operator;
        }

        // Click event handler for the back button
        private void back_btn_Click(object sender, EventArgs e) {
            // Checks to prevent user error
            //if (lastInput == inputTypes.Operator || lastInput == inputTypes.LeftParen || lastInput == inputTypes.empty) { return; }
            //currentDisplayedInput = currentDisplayedInput + "%";
            //update_calc_output_label();
            //lastInput = inputTypes.Operator;
        }

        // Click event handler for the change sign button
        private void change_sign_btn_Click(object sender, EventArgs e) {
            // Checks to prevent user error
            if (lastInput == inputTypes.Number || lastInput == inputTypes.RightParen) { return; }
            currentDisplayedInput = currentDisplayedInput + "-";
            update_calc_output_label();
            lastInput = inputTypes.Operator;
        }

        // Click event handler for the clear button
        private void clear_btn_Click(object sender, EventArgs e) {
            currentDisplayedInput = "";
            update_calc_output_label();
            lastInput = inputTypes.empty;
        }

        // Click event handler for the power button
        private void power_bt_Click(object sender, EventArgs e) {
            // Checks to prevent user error
            if (lastInput == inputTypes.Operator || lastInput == inputTypes.LeftParen) { return; }
            currentDisplayedInput = currentDisplayedInput + "^";
            update_calc_output_label();
            lastInput = inputTypes.Operator;
        }

        // Click event handler for the left parenthesis button
        private void left_paren_Click(object sender, EventArgs e) {
            // Dont allow left parens 
            if (lastInput == inputTypes.Number || lastInput == inputTypes.RightParen) { return; }
            currentDisplayedInput = currentDisplayedInput + "(";
            update_calc_output_label();
            lastInput = inputTypes.LeftParen;
            // Increase paren count
            LeftParenCount++;
        }

        // Click event handler for the right parenthesis button
        private void right_paren_Click(object sender, EventArgs e) {
            // Dont allow right parens without any left parens
            if(LeftParenCount <= 0 || lastInput == inputTypes.LeftParen || lastInput == inputTypes.Operator) { return; }
            currentDisplayedInput = currentDisplayedInput + ")";
            update_calc_output_label();
            lastInput = inputTypes.RightParen;
            // Decrease paren count
            LeftParenCount--;
        }

        //REMOVE
        private void calc_output_Click(object sender, EventArgs e)
        {
            
        }
    }
}
