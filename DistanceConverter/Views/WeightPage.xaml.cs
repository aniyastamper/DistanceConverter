using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter.Views;

public partial class WeightPage : ContentPage
{ //These Vales Are Whats being applied to our Calculations 
    double KeyValue = 0; //we will do KiloGrams 2 weight conversions

    double dbl_k2O = 35.274; //Kilograms 2 Ounces
    double dbl_k2P = 2.20462; //KiloGrams 2 Pounds
    double dbl_k2M =1000000 ; //KiloGrams 2 Miligrams
    double dbl_k2G = 1000; //KiloGrams 2 Gram
    double dbl_k2ST = 0.00110231; //KiloGrams 2 short Ton
    
    public WeightPage()
    {
        InitializeComponent();

        Title = "Weight Converter";
    }

    private void Clear_OnClicked(object sender, EventArgs e)
    {
        txtOunce.Text = string.Empty; 
        txtPound.Text = string.Empty;
        txtMilligram.Text = string.Empty;
        txtGram.Text = string.Empty;
        txtShortTon .Text = string.Empty;
        
    }

    private void Convert_OnClicked(object sender, EventArgs e)
    {
        txtOunce.Text = (KeyValue * dbl_k2O).ToString("g9");  // The G9 allows for remainders to be given for the solved expression
        txtPound.Text = (KeyValue * dbl_k2P).ToString("g9"); 
        txtMilligram.Text = (KeyValue * dbl_k2M).ToString("g9"); 
        txtGram.Text =(KeyValue * dbl_k2G).ToString("g9"); 
        txtShortTon  .Text = (KeyValue * dbl_k2ST).ToString("g9");
    }

    private void TxtOunce_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //k2O
        double dblNumber;
        var isValid = Double.TryParse(txtOunce.Text, out dblNumber);

        if (isValid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_k2O;
        }
        else
        {
            KeyValue = 0;
        }
        
    }

    private void TxtPound_OnTextChanged(object sender, TextChangedEventArgs e)
    {
       //k2P
       double dblNumber;
       var isValid = Double.TryParse(txtPound.Text, out dblNumber);

       if (isValid && dblNumber != 0)
       {
           KeyValue = dblNumber / dbl_k2P;
       }
       else
       {
           KeyValue = 0;
       }
    }

    private void TxtGram_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //k2G
        double dblNumber;
        var isValid = Double.TryParse(txtGram.Text, out dblNumber);

        if (isValid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_k2G;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtMilligram_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //k2Milli
        double dblNumber;
        var isValid = Double.TryParse(txtMilligram.Text, out dblNumber);

        if (isValid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_k2M;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtShortTon_OnTextChanged(object sender, TextChangedEventArgs e)
    {
       //k2ST
       double dblNumber;
       var isValid = Double.TryParse(txtShortTon.Text, out dblNumber);

       if (isValid && dblNumber != 0)
       {
           KeyValue = dblNumber / dbl_k2ST;
       }
       else
       {
           KeyValue = 0;
       }
    }
}