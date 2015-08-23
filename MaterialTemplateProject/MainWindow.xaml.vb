Class MainWindow
    Private Sub LightThemeCheckBox_Checked(sender As Object, e As RoutedEventArgs) Handles LightThemeCheckBox.Checked
        DarkThemeCheckBox.IsChecked = False
        Dim materialPaletteHelper = New MaterialDesignThemes.Wpf.PaletteHelper
        materialPaletteHelper.SetLightDark(False)        
    End Sub
    Private Sub DarkThemeCheckBox_Checked(sender As Object, e As RoutedEventArgs) Handles DarkThemeCheckBox.Checked
        LightThemeCheckBox.IsChecked = False
        Dim materialPaletteHelper = New MaterialDesignThemes.Wpf.PaletteHelper
        materialPaletteHelper.SetLightDark(True)         
    End Sub
    Private Sub GreenAccentCheckBox_Checked(sender As Object, e As RoutedEventArgs) Handles GreenAccentCheckBox.Checked
        Dim materialPaletteHelper = New MaterialDesignThemes.Wpf.PaletteHelper
        materialPaletteHelper.ReplacePrimaryColor("Green")
        materialPaletteHelper.ReplaceAccentColor("Green")
        RedAccentCheckBox.IsChecked = False
        CyanAccentCheckBox.IsChecked = False
    End Sub

    Private Sub RedAccentCheckBox_Checked(sender As Object, e As RoutedEventArgs) Handles RedAccentCheckBox.Checked
        Dim materialPaletteHelper = New MaterialDesignThemes.Wpf.PaletteHelper
        materialPaletteHelper.ReplacePrimaryColor("Red")
        materialPaletteHelper.ReplaceAccentColor("Red")
        GreenAccentCheckBox.IsChecked = False
        CyanAccentCheckBox.IsChecked = False
    End Sub

    Private Sub CyanAccentCheckBox_Checked(sender As Object, e As RoutedEventArgs) Handles CyanAccentCheckBox.Checked
        Dim materialPaletteHelper = New MaterialDesignThemes.Wpf.PaletteHelper
        materialPaletteHelper.ReplacePrimaryColor("Cyan")
        materialPaletteHelper.ReplaceAccentColor("Cyan")
        GreenAccentCheckBox.IsChecked = False
        RedAccentCheckBox.IsChecked = False
    End Sub

    Private Sub LightThemeCheckBox_Unchecked(sender As Object, e As RoutedEventArgs) Handles LightThemeCheckBox.Unchecked
        DarkThemeCheckBox.IsChecked = True
    End Sub

    Private Sub DarkThemeCheckBox_Unchecked(sender As Object, e As RoutedEventArgs) Handles DarkThemeCheckBox.Unchecked
        LightThemeCheckBox.IsChecked = True
    End Sub
End Class
