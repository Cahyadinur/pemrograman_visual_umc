Module MyMod
    Public api_folder As String = "apotik"
    Public obat_api As String = "http://f0833851.xsph.ru/" & api_folder & "/obat_api.php"
    Public obat_baru As Boolean

    Public penjualan_api As String = "http://f0833851.xsph.ru/" & api_folder & "/penjualan_api.php"
    Public penjualan_baru As Boolean

    Public users_api As String = "http://f0833851.xsph.ru/" & api_folder & "/users_api.php"

    Public LoginForm As New login
    Public Dashboard As New dashboard
    Public FormObat As New obat
    Public FormJual As New penjualan


    Public admin_role As Boolean = False
    Public login_valid As Boolean = False

End Module
