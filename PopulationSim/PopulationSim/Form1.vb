Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click
        Dim year As Integer
        Dim population As Double

        year = 2012
        population = 7000

        Do While (population > 6)

            year = year - 50
            population = population / 2

        Loop

        MessageBox.Show("The year is " & year, "Error")

    End Sub
End Class
