﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("KS.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to al&apos;awamir almtaht: {0}
        '''aktaba al&apos;amr:
        '''tam &apos;iilgha&apos; haqn al&apos;awamir.
        '''aifsil bayn wasaytat altamhid bifawasil bidun masafat , ealaa sabil almithal , &quot;motd ، gpuprobe&quot;
        '''&apos;awamir munfasilat ealaa &apos;cmdinject&apos; mae colons bimasafat , ealaa sabil almithal , &apos;cmdinject setthemes Hacker: beep 1024 0.5&apos;
        '''lahaz &apos;ana alwasita &apos;debug&apos; la tughatiy alnawat bialkamil.
        '''alsafaqat: alwasitat almatluba {0} ghyr mawjudatin.
        '''alsfqat: khata ghyr qabil lilaistirdad fi alwsytt:
        '''alwasayit almutahat: {0}
        '''alhujaj (&quot;almusaedat&quot; lil [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property arb() As String
            Get
                Return ResourceManager.GetString("arb", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to الأوامر المتاحة: {0}
        '''اكتب الأمر:
        '''تم إلغاء حقن الأوامر.
        '''افصل بين وسيطات التمهيد بفواصل بدون مسافات ، على سبيل المثال ، &quot;motd ، gpuprobe&quot;
        '''أوامر منفصلة على &apos;cmdinject&apos; مع colons بمسافات ، على سبيل المثال ، &apos;cmdinject setthemes Hacker: beep 1024 0.5&apos;
        '''لاحظ أن الوسيطة &apos;debug&apos; لا تغطي النواة بالكامل.
        '''الصفقات: الوسيطة المطلوبة {0} غير موجودة.
        '''الصفقات: خطأ غير قابل للاسترداد في الوسيطة:
        '''الوسائط المتاحة: {0}
        '''الحجج (&quot;المساعدة&quot; للمساعدة):
        '''سيتم جدولة الحجج المحقونة لتشغيلها عند إعادة التمهيد التالي.
        '''تم إلغاء  [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property arb_T() As String
            Get
                Return ResourceManager.GetString("arb_T", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Kěyòng mìnglìng: {0}
        '''Xiě mìnglìng: 
        '''Mìnglìng zhùrù yǐ bèi qǔxiāo.
        '''Shǐyòng dòuhào fēngé yǐndǎo cānshù, bù dài kònggé, lìrú&apos;motd,gpuprobe&apos;
        '''&apos;Cmdinject&apos; shàng de mìnglìng yǔ dài kònggé de màohào fēnkāi, lìrú&apos;cmdinject setthemes Hacker:Beep 1024 0.5&apos;
        '''Qǐng zhùyì,&apos;debug&apos;cānshù bìng bù wánquán fùgài nèihé.
        '''bargs: Zhǎo bù dào qǐngqiú de cānshù {0}.
        '''bargs: Cānshù zhōng bùkě huīfù de cuòwù:
        '''Kěyòng cānshù:{0}
        '''Cānshù (&apos;bāngzhù&apos;xúnqiú bāngzhù):
        '''Zhùrù de cānshù jiāng ānpái zàixià cì chóngxīn qǐdòng shí yùnxíng.        ''' [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property chi() As String
            Get
                Return ResourceManager.GetString("chi", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 可用命令：{0}
        '''编写命令：
        '''命令注入已被取消。
        '''引导参数之间用逗号分隔，不带空格，例如&apos;motd，gpuprobe&apos;
        '''在&apos;cmdinject&apos;上用冒号分隔空格的命令，例如&apos;cmdinject setthemes Hacker：beep 1024 0.5&apos;
        '''请注意，“ debug”参数不能完全覆盖内核。
        '''bargs：找不到请求的参数{0}。
        '''bargs：参数中无法恢复的错误：
        '''可用参数：{0}
        '''参数（“帮助”以获取帮助）：
        '''注入的参数将计划在下次重新引导时运行。
        '''参数注入已被取消。
        '''解析实际的命令行参数时出错：{0}
        '''无效的颜色模板{0}
        '''默认
        '''自订
        '''hwprobe：将检测您的硬件。请耐心等待...
        '''hwprobe：已检测到硬件。
        '''hwprobe：未检测到硬件。使用“ hwprobe”进行探测
        '''CPU：一个或多个CPU内核无法探测。仍在显示信息...
        '''RAM：无法探测一个或多个RAM芯片。仍在显示信息...
        '''HDD：无法探测一个或多个硬盘驱动器。仍在显示信息...
        '''CPU：处理器总数：{0}
        '''CPU：{0} {1} MHz
        '''RAM：{0} MB = {1} MB [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property chi_T() As String
            Get
                Return ResourceManager.GetString("chi_T", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Dostupne naredbe: {0}
        '''Napisati naredbu:
        '''Ukidanje naredbe je otkazano.
        '''Argumente pokretanja odvojite zarezima bez razmaka, na primjer, &quot;motd, gpuprobe&quot;
        '''Odvojite naredbe na &apos;cmdinject&apos; kolonama s razmacima, na primjer, &apos;cmdinject setthemes Hacker: beep 1024 0,5&apos;
        '''Imajte na umu da argument za uklanjanje pogrešaka ne pokriva u potpunosti kernel.
        '''bargs: Traženi argument {0} nije pronađen.
        '''bargs: Nerešiva ​​greška u argumentu:
        '''Dostupni argumenti: {0}
        '''Argumenti (&quot;pomoć&quot; za pomoć):
        '''Injektirani argumenti tr [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property cro() As String
            Get
                Return ResourceManager.GetString("cro", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Dostupnأ© pإ™أ­kazy: {0}
        '''Pإ™أ­kaz Write:
        '''Pإ™أ­kazovأ© injekce byla zruإ،ena.
        '''Argumenty spouإ،tؤ›nأ­ oddؤ›lte ؤچأ،rkami bez mezer, napإ™أ­klad &apos;motd, gpuprobe&apos;
        '''Samostatnأ© pإ™أ­kazy na &apos;cmdinject&apos; s dvojteؤچkami s mezerami, napإ™أ­klad &apos;cmdinject setthemes Hacker: beep 1024 0.5&apos;
        '''Povإ،imnؤ›te si, إ¾e argument &apos;debug&apos; zcela nepokrأ½vأ، jأ،dro.
        '''bargs: Poإ¾adovanأ½ argument {0} nebyl nalezen.
        '''bargs: Neodstranitelnأ، chyba v argumentu:
        '''Dostupnأ© argumenty: {0}
        '''Argumenty (nأ،povؤ›da â€‍helpâ€œ):
        '''Vloإ¾enأ [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property cze() As String
            Get
                Return ResourceManager.GetString("cze", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Tilgængelige kommandoer: {0}
        '''Skriv kommando:
        '''Kommandoinjektion er annulleret.
        '''Adskil boot-argumenter med kommaer uden mellemrum, for eksempel &apos;motd, gpuprobe&apos;
        '''Separate kommandoer på &apos;cmdinject&apos; med kolon med mellemrum, for eksempel &apos;cmdinject setthemes Hacker: bip 1024 0.5&apos;
        '''Bemærk, at &apos;debug&apos; -argumentet ikke helt dækker kernen.
        '''bargs: Det anmodede argument {0} findes ikke.
        '''bargs: Ikke genvindbar fejl i argumentet:
        '''Tilgængelige argumenter: {0}
        '''Argumenter (&apos;hjælp&apos; til hjælp):
        '''Injicerede argumenter  [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property dan() As String
            Get
                Return ResourceManager.GetString("dan", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Beschikbare opdrachten: {0}
        '''Schrijf commando:
        '''Commando-injectie is geannuleerd.
        '''Aparte opstartargumenten met komma&apos;s zonder spaties, bijvoorbeeld &apos;motd, gpuprobe&apos;
        '''Afzonderlijke opdrachten op &apos;cmdinject&apos; met dubbele punten met spaties, bijvoorbeeld &apos;cmdinject setthemes Hacker : beep 1024 0.5&apos;
        '''Merk op dat het &apos;debug&apos;-argument de kernel niet volledig dekt.
        '''bargs: het gevraagde argument {0} is niet gevonden.
        '''bargs: Onherstelbare fout in argument:
        '''Beschikbare argumenten: {0}
        '''Argumenten (&apos;help&apos; voor hulp [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property dtc() As String
            Get
                Return ResourceManager.GetString("dtc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Available commands: {0}
        '''Write command: 
        '''Command injection has been cancelled.
        '''Separate boot arguments with commas without spaces, for example, &apos;motd,gpuprobe&apos;
        '''Separate commands on &apos;cmdinject&apos; with colons with spaces, for example, &apos;cmdinject setthemes Hacker : beep 1024 0.5&apos;
        '''Note that the &apos;debug&apos; argument does not fully cover the kernel.
        '''bargs: The requested argument {0} is not found.
        '''bargs: Unrecoverable error in argument: 
        '''Available arguments: {0}
        '''Arguments (&apos;help&apos; for help): 
        '''Injected arguments  [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property eng() As String
            Get
                Return ResourceManager.GetString("eng", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Käytettävissä olevat komennot: {0}
        '''Kirjoita komento:
        '''Komentosuihku on peruutettu.
        '''Erota käynnistysasetukset pilkuilla ilman välilyöntejä, esimerkiksi &quot;motd, gpuprobe&quot;
        '''Erota komennot &apos;cmdinject&apos;: llä kolonkeilla, joissa on välilyöntejä, esimerkiksi &apos;cmdinject setthemes Hacker: beep 1024 0.5&apos;
        '''Huomaa, että debug-argumentti ei kata kokonaan ytimiä.
        '''bargs: Pyydettyä argumenttia {0} ei löydy.
        '''bargs: Palautumaton virhe argumentissa:
        '''Saatavilla olevat argumentit: {0}
        '''Argumentit (&apos;help&apos; en ohje):
        '''Injektoid [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property fin() As String
            Get
                Return ResourceManager.GetString("fin", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Commandes disponibles: {0}
        '''Commande d&apos;écriture: 
        '''L&apos;injection de commande a été annulée.
        '''Séparez les arguments de démarrage par des virgules sans espaces, par exemple &quot;motd,gpuprobe&quot;
        '''Séparez les commandes sur &apos;cmdinject&apos; avec les deux points avec des espaces, par exemple, &apos;cmdinject setthemes Hacker : beep 1024 0.5&apos;
        '''Notez que l&apos;argument &apos;debug&apos; ne couvre pas complètement le noyau.
        '''bargs: l&apos;argument demandé {0} est introuvable.
        '''bargs: erreur irrécupérable dans l&apos;argument:
        '''Arguments disponibles: {0}
        '''A [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property fre() As String
            Get
                Return ResourceManager.GetString("fre", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Verfügbare Befehle: {0}
        '''Schreibbefehl: 
        '''Die Befehlsinjektion wurde abgebrochen.
        '''Trennen Sie Boot-Argumente durch Kommas ohne Leerzeichen, z. B. &quot;motd, gpuprobe&quot;
        '''Trennen Sie Befehle in &apos;cmdinject&apos; mit Doppelpunkten mit Leerzeichen, z. B. &apos;cmdinject setthemes Hacker: beep 1024 0,5&apos;
        '''Beachten Sie, dass das Debug-Argument den Kernel nicht vollständig abdeckt.
        '''bargs: Das angeforderte Argument {0} wurde nicht gefunden.
        '''bargs: Nicht behebbarer Fehler im Argument:
        '''Verfügbare Argumente: {0}
        '''Argumente (&apos;Hilfe [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property ger() As String
            Get
                Return ResourceManager.GetString("ger", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to upalabdh aadesh: {0}
        '''kamaand likhen: 
        '''kamaand injekshan radd kar diya gaya hai.
        '''bina spes ke alpaviraam ke saath alag boot tark, udaaharan ke lie, &apos;motd, gpuprobe&apos;
        '''rikt sthaan vaale kolan ke saath chmdinjaicht par alag-alag aadesh, udaaharan ke lie, &apos;cmdinject setthemes hacker: beep 1024 0.5&apos;
        '''dhyaan den ki &apos;debug&apos; tark karnel ko pooree tarah se kavar nahin karata hai.
        '''baarg: anurodhit tark {0} nahin mila hai.
        '''baarg: tark mein apraapy truti:
        '''upalabdh tark: {0}
        '''tark (sahaayata ke lie sahaayata): 
        '''in [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property ind() As String
            Get
                Return ResourceManager.GetString("ind", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to उपलब्ध आदेश: {0}
        '''कमांड लिखें:
        '''कमांड इंजेक्शन रद्द कर दिया गया है।
        '''रिक्त स्थान के बिना अल्पविराम के साथ अलग बूट तर्क, उदाहरण के लिए, &apos;motd, gpuprobe&apos;
        '''रिक्त स्थान के साथ कॉलन के साथ &apos;cmdinject&apos; पर अलग-अलग कमांड, उदाहरण के लिए, &apos;cmdinject से हैकर्स को हटाता है: 1024 x 1024&apos;
        '''ध्यान दें कि &apos;डीबग&apos; तर्क पूरी तरह से कर्नेल को कवर नहीं करता है।
        '''bargs: अनुरोधित तर्क {0} नहीं मिला है।
        '''सौदेबाज़ी: तर्क में अपरिवर्तनीय त्रुटि:
        '''उपलब्ध तर्क: {0}
        '''तर्क (मदद के लिए &apos;सहायता):
        '''इंजेक्ट किए गए तर्कों को अगले रिबूट पर चला [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property ind_T() As String
            Get
                Return ResourceManager.GetString("ind_T", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Comandi disponibili: {0}
        '''Scrivi il comando:
        '''L&apos;iniezione del comando أ¨ stata annullata.
        '''Separare gli argomenti di avvio con virgole senza spazi, ad esempio &quot;motd, gpuprobe&quot;
        '''Comandi separati su &apos;cmdinject&apos; con i due punti con spazi, ad esempio &apos;cmdinject setthemes Hacker: beep 1024 0.5&apos;
        '''Si noti che l&apos;argomento &apos;debug&apos; non copre completamente il kernel.
        '''bargs: l&apos;argomento richiesto {0} non أ¨ stato trovato.
        '''bargs: errore irreversibile nell&apos;argomento:
        '''Argomenti disponibili: {0}
        '''Argomenti (&apos;aiuto&apos; per  [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property ita() As String
            Get
                Return ResourceManager.GetString("ita", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Riyō kanōna komando: {0}
        '''Kakikomi komando: 
        '''Komandoinjekushon wa kyanseru sa remashita. 
        '''Būto hikisū o supēsu nashi no kanma de kugirimasu. Tatoeba, `motd, gpuprobe&apos;
        '''&apos;cmdinject&apos; no komando o supēsu-tsuki no koron de kugirimasu. Tatoeba, &apos; cmdinject setthemes Hacker: beep 1024 0. 5&apos;
        '''&apos;Debaggu&apos; hikisū wa kāneru o kanzen ni wa kabā shite inai koto ni chūi shite kudasai. 
        '''Bargs: Yōkyū sa reta hikisū {0} ga mitsukarimasen. 
        '''Bargs: Hikisū no kaifuku funōna erā: 
        '''Riyō kanōna hikisū: {0} 
        '''Hikisū (herupu wa&apos; [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property jpn() As String
            Get
                Return ResourceManager.GetString("jpn", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 利用可能なコマンド：{0}
        '''書き込みコマンド：
        '''コマンドインジェクションはキャンセルされました。
        '''ブート引数をスペースなしのカンマで区切ります。たとえば、「motd、gpuprobe」
        '''&apos;cmdinject&apos;のコマンドをスペース付きのコロンで区切ります。たとえば、 &apos;cmdinject setthemes Hacker：beep 1024 0.5&apos;
        '''&apos;debug&apos;引数はカーネルを完全にはカバーしていないことに注意してください。
        '''bargs：要求された引数{0}が見つかりません。
        '''bargs：引数の回復不能なエラー：
        '''利用可能な引数：{0}
        '''引数（ヘルプは &apos;help&apos;）：
        '''注入された引数は、次回の再起動時に実行されるようにスケジュールされます。
        '''引数の挿入はキャンセルされました。
        '''実際のコマンドライン引数の解析中にエラーが発生しました：{0}
        '''無効なカラーテンプレート{0}
        '''デフォルト
        '''カスタム
        '''hwprobe：ハードウェアがプローブされます。お待ちください...
        '''hwprobe：ハードウェアはすでにプローブされています。
        '''hwprobe：ハードウェアはプローブされません。 [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property jpn_T() As String
            Get
                Return ResourceManager.GetString("jpn_T", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Perintah yang tersedia: {0}
        '''Tulis perintah:
        '''Suntikan arahan telah dibatalkan.
        '''Hantarkan butiran boot dengan koma tanpa ruang, sebagai contoh, &apos;motd, gpuprobe&apos;
        '''Perintah berasingan pada &apos;cmdinject&apos; dengan titik-titik dengan ruang, contohnya, &apos;cmdinject setthemes Hacker: bip 1024 0.5&apos;
        '''Perhatikan bahawa hujah &apos;debug&apos; tidak meliputi kernel sepenuhnya.
        '''Bargs: Hujah yang diminta {0} tidak dijumpai.
        '''bargs: Kesalahan yang tidak dapat dipulihkan dalam hujah:
        '''Hujah yang tersedia: {0}
        '''Argumen (&apos;help&apos; untuk men [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property mal() As String
            Get
                Return ResourceManager.GetString("mal", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Perintah yang tersedia: {0}
        '''Tulis perintah:
        '''Perintah injeksi telah dibatalkan.
        '''Pisahkan argumen boot dengan koma tanpa spasi, misalnya, &apos;motd, gpuprobe&apos;
        '''Pisahkan perintah pada &apos;cmdinject&apos; dengan titik dua dengan spasi, misalnya, &apos;cmdinject setthemes Hacker: beep 1024 0.5&apos;
        '''Perhatikan bahwa argumen &apos;debug&apos; tidak sepenuhnya mencakup kernel.
        '''bargs: Argumen yang diminta {0} tidak ditemukan.
        '''bargs: Kesalahan yang tidak dapat dipulihkan dalam argumen:
        '''Argumen yang tersedia: {0}
        '''Argumen (&apos;bantuan&apos; untuk ba [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property ndo() As String
            Get
                Return ResourceManager.GetString("ndo", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Dostępne polecenia: {0}
        '''Napisz polecenie:
        '''Wprowadzanie poleceń zostało anulowane.
        '''Oddziel argumenty rozruchowe przecinkami bez spacji, na przykład „motd, gpuprobe”
        '''Oddzielne polecenia na „cmdinject” z dwukropkami ze spacjami, na przykład „cmdinject setthemes Hacker: beep 1024 0,5”
        '''Zauważ, że argument „debugowanie” nie obejmuje w pełni jądra.
        '''bargs: Żądany argument {0} nie został znaleziony.
        '''bargs: Nieodwracalny błąd w argumencie:
        '''Dostępne argumenty: {0}
        '''Argumenty („pomoc” dla pomocy):
        '''Wstrzyknięte [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property pol() As String
            Get
                Return ResourceManager.GetString("pol", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Comandos disponíveis: {0}
        '''Comando de gravação: 
        '''A injeção de comando foi cancelada.
        '''Separe os argumentos de inicialização com vírgulas sem espaços, por exemplo, &apos;motd, gpuprobe&apos;
        '''Comandos separados em &apos;cmdinject&apos; com dois-pontos com espaços, por exemplo, &apos;cmdinject setthemes Hacker: beep 1024 0.5&apos;
        '''Note que o argumento &apos;debug&apos; não cobre completamente o kernel.
        '''bargs: O argumento solicitado {0} não foi encontrado.
        '''bargs: Erro irrecuperável no argumento:
        '''Argumentos disponíveis: {0}
        '''Argumentos (&apos;help&apos; f [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property ptg() As String
            Get
                Return ResourceManager.GetString("ptg", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Comenzi disponibile: {0}
        '''Comanda de scriere:
        '''Injectarea comenzii a fost anulată.
        '''Separați argumentele de pornire cu virgule fără spații, de exemplu, &apos;motd, gpuprobe&apos;
        '''Separa comenzile de pe „cmdinject” cu coloane cu spații, de exemplu, „cmdinject setthemes Hacker: bip 1024 0.5”
        '''Rețineți că argumentul „debug” nu acoperă complet nucleul.
        '''bargs: Argumentul solicitat {0} nu este găsit.
        '''bargs: eroare care nu poate fi recuperată în argument:
        '''Argumente disponibile: {0}
        '''Argumente („ajutor” pentru ajutor):
        ''' [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property rmn() As String
            Get
                Return ResourceManager.GetString("rmn", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Dostupnyye komandy: {0}
        '''Napisat&apos; komandu:
        '''Komandnaya in&quot;yektsiya byla otmenena.
        '''Otdel&apos;nyye argumenty zagruzki s zapyatymi bez probelov, naprimer, &apos;motd, gpuprobe&apos;
        '''Otdel&apos;nyye komandy dlya «cmdinject» s dvoyetochiyami s probelami, naprimer, «cmdinject setthemes Hacker: beep 1024 0.5»
        '''Obratite vnimaniye, chto argument debug ne polnost&apos;yu pokryvayet yadro.
        '''bargs: zaproshennyy argument {0} ne nayden.
        '''bargs: neispravimaya oshibka v argumente:
        '''Dostupnyye argumenty: {0}
        '''Argumenty («pomoshch&apos;» dlya pomoshch [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property rus() As String
            Get
                Return ResourceManager.GetString("rus", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Доступные команды: {0}
        '''Написать команду:
        '''Командная инъекция была отменена.
        '''Отдельные аргументы загрузки с запятыми без пробелов, например, &apos;motd, gpuprobe&apos;
        '''Отдельные команды для «cmdinject» с двоеточиями с пробелами, например, «cmdinject setthemes Hacker: beep 1024 0.5»
        '''Обратите внимание, что аргумент debug не полностью покрывает ядро.
        '''bargs: запрошенный аргумент {0} не найден.
        '''bargs: неисправимая ошибка в аргументе:
        '''Доступные аргументы: {0}
        '''Аргументы («помощь» для помощи):
        '''Введенные аргументы буд [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property rus_T() As String
            Get
                Return ResourceManager.GetString("rus_T", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Comandos disponibles: {0}
        '''Comando de escritura: 
        '''La inyección de comandos ha sido cancelada.
        '''Separe los argumentos de arranque con comas sin espacios, por ejemplo, &apos;motd, gpuprobe&apos;
        '''Comandos separados en &apos;cmdinject&apos; con dos puntos con espacios, por ejemplo, &apos;cmdinject setthemes Hacker: beep 1024 0.5&apos;
        '''Tenga en cuenta que el argumento &apos;depurar&apos; no cubre completamente el kernel.
        '''bargs: el argumento solicitado {0} no se encuentra.
        '''bargs: error irrecuperable en el argumento: 
        '''Argumentos disponibles: {0}
        ''' [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property spa() As String
            Get
                Return ResourceManager.GetString("spa", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Tillgأ¤ngliga kommandon: {0}
        '''Skriv kommando:
        '''Kommandoinjektion har avbrutits.
        '''Separata startargument med kommatecken utan mellanslag, till exempel &quot;motd, gpuprobe&quot;
        '''Separata kommandon pأ¥ &apos;cmdinject&apos; med kolonner med mellanslag, till exempel &apos;cmdinject setthemes Hacker: pip 1024 0.5&apos;
        '''Observera att argumentet &quot;debug&quot; inte helt tأ¤cker kأ¤rnan.
        '''prأ¥mar: Det begأ¤rda argumentet {0} hittades inte.
        '''prأ¥mar: Oأ¥terkalleligt fel i argument:
        '''Tillgأ¤ngliga argument: {0}
        '''Argument (&apos;help&apos; fأ¶r hjأ¤lp):
        '''Injice [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property swe() As String
            Get
                Return ResourceManager.GetString("swe", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Kullanؤ±labilir komutlar: {0}
        '''Yazma komutu:
        '''Komut enjeksiyonu iptal edildi.
        '''أ–nyأ¼kleme argأ¼manlarؤ±nؤ± boإںluksuz virgأ¼llerle ayؤ±rؤ±n, أ¶rneؤںin, &apos;motd, gpuprobe&apos;
        '''&apos;cmdinject&apos; ifadesinde boإںluklu virgأ¼llerle ayrؤ± komutlar, أ¶rneؤںin &apos;cmdinject setthemes Hacker: beep 1024 0.5&apos;
        '''&apos;hata ayؤ±klama&apos; argأ¼manؤ±nؤ±n أ§ekirdeؤںi tamamen kapsamadؤ±ؤںؤ±nؤ± unutmayؤ±n.
        '''bargs: ؤ°stenen argأ¼man {0} bulunamadؤ±.
        '''bargs: Baؤںؤ±msؤ±z deؤںiإںkende kurtarؤ±lamaz hata:
        '''Kullanؤ±labilir deؤںiإںkenler: {0}
        '''Baؤںؤ±msؤ [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property tky() As String
            Get
                Return ResourceManager.GetString("tky", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Mavjud buyruqlar: {0}
        '''Yozish buyrug&apos;i:
        '''Buyruqni kiritish bekor qilindi.
        '''Bo&apos;sh joylarsiz vergul bilan alohida yuklash argumentlari, masalan, &quot;motd, gpuprobe&quot;
        '''&quot;Cmdinject&quot; dagi alohida buyruqlar bo&apos;sh joy qoldirilgan ustunlar bilan, masalan, &quot;cmdinject sxemalari Hacker: signal 1024 0.5&quot;
        '''E&apos;tibor bering, &quot;disk raskadrovka&quot; argumenti yadroni to&apos;liq qamrab olmaydi.
        '''bargs: Talab qilingan {0} argument topilmadi.
        '''Bars: argumentda tuzatib bo&apos;lmaydigan xato:
        '''Mavjud dalillar: {0}
        '''Dalillar (yordam uchun &apos;yordam&apos; [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property uzb() As String
            Get
                Return ResourceManager.GetString("uzb", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Các lệnh khả dụng: {0}
        '''Viết lệnh:
        '''Lệnh tiêm đã bị hủy bỏ.
        '''Các đối số khởi động riêng biệt với dấu phẩy không có dấu cách, ví dụ: &apos;motd,gpuprobe&apos;
        '''Các lệnh riêng biệt trên &apos;cmdinject&apos; với dấu hai chấm có dấu cách, ví dụ: &apos;cmdinject setthemes Hacker: beep 1024 0.5&apos;
        '''Lưu ý rằng đối số &apos;gỡ lỗi&apos; không bao gồm đầy đủ kernel.
        '''xà lan: Không tìm thấy đối số được yêu cầu {0}.
        '''xà lan: Lỗi không thể phục hồi trong đối số:
        '''Đối số khả dụng: {0}
        '''Đối số (&apos;trợ giúp&apos; để được giúp đỡ):
        '''Các đối số được tiêm sẽ được lên [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property vtn() As String
            Get
                Return ResourceManager.GetString("vtn", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
