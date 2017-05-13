using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Who_wants_to_be_a_Millionaire
{

    public partial class Form2 : Form
    {
        SoundPlayer audienceSound = new SoundPlayer(Properties.Resources.audienceSound);
        SoundPlayer falsch = new SoundPlayer(Properties.Resources.falsch);
        SoundPlayer richtig = new SoundPlayer(Properties.Resources.richtig);
        SoundPlayer intro = new SoundPlayer(Properties.Resources.intro);
        SoundPlayer _50_50 = new SoundPlayer(Properties.Resources._50_50);
        SoundPlayer erotisi = new SoundPlayer(Properties.Resources.erotisi);

        public static int count = 0;
        public static int cd = 20;
       // public static int x = 0;
        List<string> level1 = new List<string>();
        List<string> level1answers = new List<string>();

        List<string> level2 = new List<string>();
        List<string> level2answers = new List<string>();

        public static int level=1;
        public static int onoff = 0;
        public static Random lvl = new Random();
        public static Random lvla = new Random();

        public static int lev = 0;
        public static int leva = 0;
        public static int leva1 = 0;
        public static int leva2 = 0;
        public static int leva3 = 0;

        public static int num1 = 0;
        public static int num2 = 0;
        public static int num3 = 0;
        public static int num4 = 0;
        public static int num5 = 0;
        public static int num6 = 0;

        

        public static int chartcount = 0;

        public static Random num = new Random();

        public Form2()
        {
            InitializeComponent();
            var pos = this.PointToScreen(label21.Location);
            pos = pictureBox1.PointToClient(pos);
            label21.Parent = pictureBox1;
            label21.Location = pos;
            label21.BackColor = Color.Transparent;
            pictureBox1.Visible = false;

            lev = lvl.Next(0, 5);
            chart1.Visible = false;

            //====================================================
            //LEVEL 1
            //0-4 && 0-19

            level1.Add("Σε ποια θάλασσα εκβάλει ο Δούναβης;");
            level1.Add("Πόσες ήταν οι Καρυάτιδες;");
            level1.Add("Πώς μαγειρεύουν το ρύζι οι Κινέζοι;");
            level1.Add("Ποιος είναι ο κοντινότερος πλανήτης στον Ήλιο;");
            level1.Add("Ποια χώρα είναι η πρώτη στην κατανάλωση μπίρας ανά κεφαλή;");

            level1answers.Add("Στην Μαύρη Θάλασσα");
            level1answers.Add("Στην Ερυθρά Θάλασσα");
            level1answers.Add("Στην Μεσόγειο");
            level1answers.Add("Στην Αδριατική Θάλασσα");

            level1answers.Add("7");
            level1answers.Add("9");
            level1answers.Add("12");
            level1answers.Add("3");

            level1answers.Add("Βραστό και τηγανητό");
            level1answers.Add("Βραστό");
            level1answers.Add("Στον φούρνο");
            level1answers.Add("Βραστό και στον φούρνο");

            level1answers.Add("Ο Ερμής");
            level1answers.Add("Ο Πλούτωνας");
            level1answers.Add("Η Αφροδίτη");
            level1answers.Add("Ο Δίας");

            level1answers.Add("Η Γερμανία");
            level1answers.Add("Η Ελλάδα");
            level1answers.Add("Η Αυστρία");
            level1answers.Add("Η Νορβηγία");

            //====================================================
            //LEVEL 2
            //5-9 && 20-39

            level1.Add("Με πόσες κορίνες παίζεται το Bowling;");
            level1.Add("Τι χρώμα έχει το μελάνι της σουπιάς;");
            level1.Add(" Ποιος ο ζωγράφος της Τζοκόντας;");
            level1.Add("Ποιο είναι το μεγαλύτερο νησί των Δωδεκαννήσων;");
            level1.Add("Ποιο το όργανο μετρήσεως της θερμοκρασίας;");

            level1answers.Add("Με 10");
            level1answers.Add("Με 7");
            level1answers.Add("Με 12");
            level1answers.Add("Με 6");

            level1answers.Add("Μαύρο");
            level1answers.Add("Σκούρο Μπλε");
            level1answers.Add("Μπλε");
            level1answers.Add("Καφέ");

            level1answers.Add("Ο Λεονάρντο Ντα Βίντσι");
            level1answers.Add("Ο Πικάσο");
            level1answers.Add("Ο Νταλί");
            level1answers.Add("Ο Βαν Γκογκ");

            level1answers.Add("Η Ρόδος");
            level1answers.Add("Η Κάλυμνος");
            level1answers.Add("Η Ίος");
            level1answers.Add("Η Λέσβος");

            level1answers.Add("Το θερμόμετρο");
            level1answers.Add("Το βαρόμετρο");
            level1answers.Add("Το μανόμετρο	");
            level1answers.Add("Το ανεμόμτερο");

            //==================================================
            //level 3
            //40-59
            level1.Add("Μεταξύ ποιων δύο νησιών είναι τα Κουφονήσια;");
            level1.Add("Ποια η κοινή ονομασία του άνθρακα;");
            level1.Add("Με πόσα κομμάτια παίζεται το σκάκι;");
            level1.Add("Ποιος ο συγγραφέας του Άμλετ;");
            level1.Add("Τι αριθμό έχει η μαύρη μπάλα στο αμερικανικό μπιλιάρδο;");


            level1answers.Add("Νάξος - Αμοργός");
            level1answers.Add("Γουαδελούπη - Μαρτινίκα");
            level1answers.Add("Μπαχάμες - Τζαμάικα");
            level1answers.Add("Ίος - Φολέγανδρος");

            level1answers.Add("Κάρβουνο");
            level1answers.Add("Αλάτι");
            level1answers.Add("Βιταμίνη C");
            level1answers.Add("Διαμάντι");

            level1answers.Add("Με 32 ");
            level1answers.Add("Με 28 ");
            level1answers.Add("Με 42");
            level1answers.Add("Με 38");

            level1answers.Add("Ο Σαίξπηρ");
            level1answers.Add("Ο Μαρκ Τουαίν");
            level1answers.Add("Ο Βίκτωρ Ουγκο");
            level1answers.Add("Ο Κάρολος Ντίκενς");

            level1answers.Add("8");
            level1answers.Add("10");
            level1answers.Add("6");
            level1answers.Add("7");


            //==================================================
            //level 4
            //60-79
            level1.Add("Τι άλλο εκτός από μαθηματικός ήταν ο Αρχιμήδης;");
            level1.Add("Ποια Ιταλική πόλη έχει τις περισσότερες γέφυρες;");
            level1.Add("Ποιο το χημικό σύμβολο του άνθρακα;");
            level1.Add("Ποιος έκανε ποίημα τον Τρωικό Πόλεμο;");
            level1.Add("Ποιο χορταρικό έτρωγαν οι Ρωμαίοι για να μην μεθύσουν;");

            level1answers.Add("Φυσικός και μηχανικός");
            level1answers.Add("Φιλόλογος");
            level1answers.Add("Μηχανικός");
            level1answers.Add("Φιλόσοφος");

            level1answers.Add("Η Βενετία");
            level1answers.Add("Η Τεργέστη");
            level1answers.Add("Η Λουιζιάνα");
            level1answers.Add("Η Ρώμη");

            level1answers.Add("C");
            level1answers.Add("Cr");
            level1answers.Add("Ca");
            level1answers.Add("Cl");

            level1answers.Add("Ο Όμηρος");
            level1answers.Add("Ο Διονύσιος Σολωμός");
            level1answers.Add("Ο Γεώργιος Σεφέρης");
            level1answers.Add("Ο Κωστής Παλαμάς");

            level1answers.Add("Μαιντανό");
            level1answers.Add("Δυόσμο");
            level1answers.Add("Βλίτα");
            level1answers.Add("Βολβούς");

            //========================================
            //level 5
            //80-99
            level1.Add("Σε ποιον κόλπο είναι οι Αλκυονίδες Νήσοι;");
            level1.Add("Ποιο ελληνικό νησί ήταν το Φιόρε ντι Λεβάντε;");
            level1.Add("Με ποια ταχύτητα φεύγει η μπάλα του τένις στο δυνατό σερβίς;");
            level1.Add("Πώς πέθανε ο Ρόκυ Μαρτσιάνο;");
            level1.Add("Πότε ξεκίνησαν οι πρώτοι αγώνες ράλλυ;");

            level1answers.Add("Κορινθιακός Κόλπος");
            level1answers.Add("Αργολικός Κόλπος");
            level1answers.Add("Θερμαικός Κόλπος");
            level1answers.Add("Σαρωνικός Κόλπος");

            level1answers.Add("Η Ζάκυνθος");
            level1answers.Add("Η Κεφαλονιά");
            level1answers.Add("Η Ύδρα");
            level1answers.Add("Η Αμοργός");

            level1answers.Add("250 χλμ. την ώρα");
            level1answers.Add("350 χλμ. την ώρα");
            level1answers.Add("450 χλμ. την ώρα");
            level1answers.Add("500 χλμ. την ώρα");

            level1answers.Add("Σε αεροπορικπό δυστύχημα");
            level1answers.Add("Δολοφονήθηκε");
            level1answers.Add("Από τροφική δηλητηρίαση");
            level1answers.Add("Σε αυτοκινηστικό δυστύχημα");

            level1answers.Add("Το 1894");
            level1answers.Add("Το 1854");
            level1answers.Add("Το 1824");
            level1answers.Add("Το 1874");

            //===================================================
            //level 6 
            //100-119

            level1.Add("Ποιο μουσείο στην Αγγλία είναι γνωστό για τα κέρινα ομοιώματα;");
            level1.Add("Πότε βγήκε η Ιταλία για πρώτη φορά παγκόσμια πρωταθλήτρια ποδοσφαίρου;");
            level1.Add("Που είναι το μεγαλύτερο υπόγειο σιδηροδρομικό δίκτυο στον κόσμο;");
            level1.Add("Ποιο αντιβιοτικό υπάρχει μέσα στο ροκφόρ;");
            level1.Add("Πότε έγιναν οι Ολυμπιακοί αγώνες για πρώτη φορά από την τηλεόραση;");

            level1answers.Add("Μαντάμ Τυσό");
            level1answers.Add("Ασμόλειο Μουσείο ");
            level1answers.Add("Charles Dickens Museum");
            level1answers.Add("Βικτορίας και Αλβέρτου");

            level1answers.Add("Το 1934");
            level1answers.Add("Το 1924");
            level1answers.Add("Το 1954");
            level1answers.Add("Το 1964");

            level1answers.Add("Στο Λονδίνο");
            level1answers.Add("Στην Αμερική	");
            level1answers.Add("Στην Κορέα");
            level1answers.Add("Στο Παρίσι");

            level1answers.Add("Η πενικιλλίνη");
            level1answers.Add("Το άμυλο");
            level1answers.Add("Η κεφαμυκίνη");
            level1answers.Add("Η κεφαλοσπορίνη");

            level1answers.Add("Το 1936");
            level1answers.Add("Το 1932");
            level1answers.Add("Το 1944");
            level1answers.Add("Το 1948");

            //==========================================
            //level 7
            //120-139

            level1.Add("Ποιος ανακάλυψε τις τροχαλίες;");
            level1.Add("Πόσα λίτρα έχει το γαλόνι;");
            level1.Add("Ποια η μούσα της Κωμωδίας;");
            level1.Add("Ποιο το μικρότερο ποτάμι της Ευρώπης;");
            level1.Add("Που έγινε το πρώτο πρωτάθλημα στίβου;");

            level1answers.Add("Ο Αρχιμήδης");
            level1answers.Add("Ο Αριστοτέλης");
            level1answers.Add("Ο Σοφοκλής");
            level1answers.Add("Ο Περικλής");

            level1answers.Add("4.543 λίτρα");
            level1answers.Add("5.443 λίτρα");
            level1answers.Add("3.534 λίτρα");
            level1answers.Add("1.345 λίτρα");

            level1answers.Add("Η Θάλεια");
            level1answers.Add("Η Ευτέρπη");
            level1answers.Add("Η Ερατώ");
            level1answers.Add("Η Πολύμνια");

            level1answers.Add("Ο Βόλγας");
            level1answers.Add("Ο Ασωπός");
            level1answers.Add("Ο Δούναβης");
            level1answers.Add("Ο Ρήνος");

            level1answers.Add("Στο Ελσίνκι");
            level1answers.Add("Στην Στοκχόλμη");
            level1answers.Add("Στο Βερολίνο");
            level1answers.Add("Στο Παρίσι");

            //==========================================================
            //LEVEL 8
            //140-159

            level1.Add("Ποια η αναπηρία του Αννίβα;");
            level1.Add("Ποια η τελευταία αυτοκρατορική δυναστεία της Κίνας;");
            level1.Add("Πότε καταργήθηκε στην Αμερική η δουλεία;");
            level1.Add("Πώς αλλιώς λέγεται το σκάκι;");
            level1.Add("Πόσες λακούβες έχει η μπάλα του γκολφ;");

            level1answers.Add("Ήταν τυφλός απ το ένα μάτι");
            level1answers.Add("Του έλειπε ένα δάχτυλο");
            level1answers.Add("Ήταν μουγγός");
            level1answers.Add("Ήταν κουφός");

            level1answers.Add("Η Μινγκ");
            level1answers.Add("Η Τσινγκ");
            level1answers.Add("Η Χαν");
            level1answers.Add("Η Σανγκ");

            level1answers.Add("Το 1865");
            level1answers.Add("Το 1565");
            level1answers.Add("Το 1665");
            level1answers.Add("Το 1765");


            level1answers.Add("Ζατρίκιο");
            level1answers.Add("Ματρίκιο");
            level1answers.Add("Χατρίκιο");
            level1answers.Add("Βατρίκιο");

            level1answers.Add("336");
            level1answers.Add("394");
            level1answers.Add("326");
            level1answers.Add("368");

            //=========================================
            //Level 9
            //160-179

            level1.Add("Που είναι η έδρα του πρακτορείου ειδήσεων Tass;");
            level1.Add("Τι εθνικότητας ήταν ο διαιτητής τελικού Μουντιάλ 1966;");
            level1.Add("Ποια εταιρία κατασκεύασε τις πρώτες γραφομηχανές;");
            level1.Add("Πώς λέγεται ο ναύκληρος αλλιώς σε ένα εμπορικό πλοίο;");
            level1.Add("Τι είναι το καντάρι;");

            level1answers.Add("Στη Μόσχα");
            level1answers.Add("Στην Κοπεγχάγη");
            level1answers.Add("Στην Βιέννη");
            level1answers.Add("Στο Ελσίνκι");

            level1answers.Add("Ελβετός");
            level1answers.Add("Καναδέζος");
            level1answers.Add("Αυστραλός");
            level1answers.Add("Γάλλος");

            level1answers.Add("Η Ρέμιγκτον");
            level1answers.Add("Η Ντισέρτο");
            level1answers.Add("Η Φράνσαις Πόρταλ");
            level1answers.Add("Η Μπέρινγκεν");

            level1answers.Add("Λοστρόμος");
            level1answers.Add("Καμαροτάκι");
            level1answers.Add("Τσιφ");
            level1answers.Add("Ναύτης");

            level1answers.Add("Μονάδα βάρους");
            level1answers.Add("Μονάδα μήκους");
            level1answers.Add("Μονάδα πίεσης αέρος");
            level1answers.Add("Μονάδα δίσκου");

            //=====================================
            //Level 10
            //180-199

            level1.Add("Ποιος έγραψε την απολογία του Σωκράτη;");
            level1.Add("Κάθε πότε αλλάζουν τα κέρατά τους τα αρσενικά ζαρκάδια;");
            level1.Add("Πώς αλλιώς λέγεται η 3η Συμφωνία του Μπετόβεν;");
            level1.Add("Ποιος ο συνθέτης του έργου 'Τα παραμύθια του Χόφμαν';");
            level1.Add("Που έγινε το παγκόσμιο πρωτάθλημα Μουντιάλ 1950;");

            level1answers.Add("Ο Πλάτωνας");
            level1answers.Add("Ο ίδιος");
            level1answers.Add("Ο Ξενοφώντας");
            level1answers.Add("Ο Αλκιβιάδης");

            level1answers.Add("Κάθε χρόνο");
            level1answers.Add("Κάθε 2 χρόνια");
            level1answers.Add("Κάθε δεκαετία");
            level1answers.Add("Κάθε εξάμηνο");

            level1answers.Add("Ηρωική");
            level1answers.Add("Χορωδιακή");
            level1answers.Add("Δυναμική");
            level1answers.Add("Ποιμενική");

            level1answers.Add("Ιάκωβος Οφφενμπαχ");
            level1answers.Add("Άλμπερτ Χόφμαν");
            level1answers.Add("Χανς Κρίστιαν Άντερσεν");
            level1answers.Add("Σαρλ Περώ");

            level1answers.Add("Στην Ουρουγουάη");
            level1answers.Add("Στην Ιταλία");
            level1answers.Add("Στο Μεξικό");
            level1answers.Add("Στην Αργεντινή");

            //=============================================
            //level 11
            //200-219


            level1.Add("Κάθε πότε αλλάζουν το κέλυφός τους οι μεγάλοι αστακοί;");
            level1.Add("Ποιον αιώνα εφευρέθηκαν τα γυαλιά που φοράμε;");
            level1.Add("Ποιό ήταν το ποσό της μεταγραφής του Νάσου Γαλακτερού;");
            level1.Add("Πόσο χρονών ήταν η Μαρία Κάλλας όταν ήρθε να ζήσει στην Αθήνα;");
            level1.Add("Ποιο το μεγαλύτερο ποτάμι της Δυτικής Ευρώπης;");

            level1answers.Add("Κάθε χρόνο");
            level1answers.Add("Κάθε 2 χρόνια");
            level1answers.Add("Κάθε εξάμηνο");
            level1answers.Add("Κάθε 4 χρόνια");

            level1answers.Add("Τον 13ο");
            level1answers.Add("Τον 11ο");
            level1answers.Add("Τον 14ο");
            level1answers.Add("Τον 9ο");

            level1answers.Add("170 εκατομμύρια");
            level1answers.Add("100 εκατομμύρια");
            level1answers.Add("120 χιλιάδες");
            level1answers.Add("160 χιλιάδες");

            level1answers.Add("13");
            level1answers.Add("8");
            level1answers.Add("17");
            level1answers.Add("15");

            level1answers.Add("Ο Ρήνος");
            level1answers.Add("Ο Βόλγας");
            level1answers.Add("Ο Δούναβης");
            level1answers.Add("Ο Σηκουάνας");

            //=========================================
            //level 12
            //220-239


            level1.Add("Ποια η μεγαλύτερη απόσταση που έχει διανυθεί από υπνοβάτη;");
            level1.Add("Που γεννήθηκε ο Τούρκος Αρσιβαρίστας Σουλειμάνογλου;");
            level1.Add("Ποια ήταν η γυναίκα του Φαραώ της Αιγύπτου Αχενατών;");
            level1.Add("Που έγινε ο τελικός κυπέλλου κυπελλούχων ποδοσφαίρου το 1983;");
            level1.Add("Ποιος ο συνθέτης του 'Ριγκολέτο';");

            level1answers.Add("160 χλμ");
            level1answers.Add("560 μέτρα");
            level1answers.Add("120 χλμ");
            level1answers.Add("840 μέτρα");

            level1answers.Add("Στην Βουλγαρία");
            level1answers.Add("Στην Τουρκία");
            level1answers.Add("Στην Αρμενία");
            level1answers.Add("Στην Ρουμανία");

            level1answers.Add("Η Νεφερτίτη");
            level1answers.Add("Η Χατσεψούτ");
            level1answers.Add("Η Αρσινόη");
            level1answers.Add("Η Αλκέμη");

            level1answers.Add("Στο Γκέτεμπουργκ");
            level1answers.Add("Στην Γλασκώβη");
            level1answers.Add("Στο Ρότερνταμ");
            level1answers.Add("Στο Στρασβούργο");

            level1answers.Add("Ο Τζουζέπε Βέρντι");
            level1answers.Add("Ο Μίχαελ Πρετόριους");
            level1answers.Add("Ο Αρκάντζελο Κορέλι");
            level1answers.Add("Ο Αντόνιο Μπερτάλι");

            //================================
            //level 13
            //240-259


            level1.Add("Ποια βασίλισσα ίδρυσε την Καρχηδόνα;");
            level1.Add("Σε πόσα νησιά είναι χτισμένη η Βενετία;");
            level1.Add("Ποιο νησί είναι η πατρίδα του Ανδρέα Κάλβου;");
            level1.Add("Πότε έλαβε η Ρουμανία για πρώτη φορά μέρος σε Μουντιάλ;");
            level1.Add("Ποιο υλικό χρησιμοποιούσαν παλιότερα για τα ελατήρια των ρολογιών τσέπης;");

            level1answers.Add("Η Διδώ");
            level1answers.Add("Η Βρισηίς");
            level1answers.Add("Η Αελλώ");
            level1answers.Add("Η Θεογονία");

            level1answers.Add("118");
            level1answers.Add("98");
            level1answers.Add("74");
            level1answers.Add("136");

            level1answers.Add("Η Ζάκυνθος");
            level1answers.Add("Η Κεφαλονιά");
            level1answers.Add("Η Κάλυμνος");
            level1answers.Add("Η Ρόδος");

            level1answers.Add("Το 1930");
            level1answers.Add("Το 1950");
            level1answers.Add("Το 1978");
            level1answers.Add("Το 1962");

            level1answers.Add("Γουρουνότριχα");
            level1answers.Add("Κλωστή");
            level1answers.Add("Σχοινί");
            level1answers.Add("Καραβόπανο");

            //==============================================
            //level 14
            //260-279

            level1.Add("Ποιοι έφεραν για πρώτη φορά ζάχαρη στην Ευρώπη;");
            level1.Add("Από που κατάγεται ο ορειβάτης Ράινχολντ Μέσσνερ;");
            level1.Add("Ποιος ο βασιλιάς των Αζτέκων τον 15ο αιώνα;");
            level1.Add("Ποιος ποιητής έγραψε το έργο 'Οι Ωδές';");
            level1.Add("Ποιο λεγόταν ότι είναι το εθνικό φαγητό του Έλληνα;");

            level1answers.Add("Οι Σταυροφόροι");
            level1answers.Add("Οι Πραιτωριανοί");
            level1answers.Add("Οι Ναΐτες");
            level1answers.Add("Οι Μυρμιδόνες");

            level1answers.Add("Τυρόλο");
            level1answers.Add("Τορίνο");
            level1answers.Add("Βιτσέντσα");
            level1answers.Add("Λορέτο");

            level1answers.Add("Μοντεζούμα Α'");
            level1answers.Add("Ερνάν Κορτές");
            level1answers.Add("Κουαοτέμοκ");
            level1answers.Add("Τλακαέλελ");

            level1answers.Add("Ανδρέας Κάλβος");
            level1answers.Add("Γιάννης Ρίτσος");
            level1answers.Add("Γεώργιος Σουρής");
            level1answers.Add("Νάνος Βαλαωρίτης");

            level1answers.Add("Φασολάδα");
            level1answers.Add("Μουσακάς");
            level1answers.Add("Παστίτσιο");
            level1answers.Add("Φασολάκια");


        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (level==1)
            { 
            lev = lvl.Next(0, 5);

            if(lev==0)
            { Levelz(0, 0, 4); }
            else if (lev == 1)
            { Levelz(1, 4, 8); }
            else if (lev == 2)
            { Levelz(2, 8, 12); }
           else if (lev == 3)
            { Levelz(3, 12, 16); }
            else if (lev == 4)
            { Levelz(4, 16, 20); }
            }

            if (level==2)
            {
                lev = lvl.Next(5, 10);

                resettexbox();
                    if (lev == 5)
                { Levelz(5, 20, 24); }
                else if (lev == 6)
                { Levelz(6, 24, 28); }
                else if (lev == 7)
                { Levelz(7, 28, 32); }
                else if (lev == 8)
                { Levelz(8, 32, 36); }
                else if (lev == 9)
                { Levelz(9, 36, 40); }
            }

            if (level==3)
            {
                lev = lvl.Next(10, 15);
                resettexbox();
                if (lev == 10)
                { Levelz(10, 40, 44); }
                else if (lev == 11)
                { Levelz(11, 44, 48); }
                else if (lev == 12)
                { Levelz(12, 48, 52); }
                else if (lev == 13)
                { Levelz(13, 52, 56); }
                else if (lev == 14)
                { Levelz(14, 56, 60); }

            }
            if (level == 4)
            {
                lev = lvl.Next(15, 20);
                resettexbox();
                if (lev == 15)
                { Levelz(15, 60, 64); }
                else if (lev == 16)
                { Levelz(16, 64, 68); }
                else if (lev == 17)
                { Levelz(17, 68, 72); }
                else if (lev == 18)
                { Levelz(18, 72, 76); }
                else if (lev == 19)
                { Levelz(19, 76, 80); }

            }
            if (level == 5)
            {
                lev = lvl.Next(20, 25);
                resettexbox();
                if (lev == 20)
                { Levelz(20, 80, 84); }
                else if (lev == 21)
                { Levelz(21, 84, 88); }
                else if (lev == 22)
                { Levelz(22, 88, 92); }
                else if (lev == 23)
                { Levelz(23, 92, 96); }
                else if (lev == 24)
                { Levelz(24, 96, 100); }
            }
            if (level == 6)
            {
                lev = lvl.Next(25, 30);
                resettexbox();
                if (lev == 25)
                { Levelz(25, 100, 104); }
                else if (lev == 26)
                { Levelz(26, 104, 108); }
                else if (lev == 27)
                { Levelz(27, 108, 112); }
                else if (lev == 28)
                { Levelz(28, 112, 116); }
                else if (lev == 29)
                { Levelz(29, 116, 120); }
            }
            if (level == 7)
            {
                lev = lvl.Next(30, 35);
                resettexbox();
                if (lev == 30)
                { Levelz(30, 120, 124); }
                else if (lev == 31)
                { Levelz(31, 124, 128); }
                else if (lev == 32)
                { Levelz(32, 128, 132); }
                else if (lev == 33)
                { Levelz(33, 132, 136); }
                else if (lev == 34)
                { Levelz(34, 136, 140); }
            }
            if (level == 8)
            {
                lev = lvl.Next(35, 40);
                resettexbox();
                if (lev == 35)
                { Levelz(35, 140, 144); }
                else if (lev == 36)
                { Levelz(36, 144, 148); }
                else if (lev == 37)
                { Levelz(37, 148, 152); }
                else if (lev == 38)
                { Levelz(38, 152, 156); }
                else if (lev == 39)
                { Levelz(39, 156, 160); }
            }
            if (level == 9)
            {
                lev = lvl.Next(40, 45);
                resettexbox();
                if (lev == 40)
                { Levelz(40, 160, 164); }
                else if (lev == 41)
                { Levelz(41, 164, 168); }
                else if (lev == 42)
                { Levelz(42, 168, 172); }
                else if (lev == 43)
                { Levelz(43, 172, 176); }
                else if (lev == 44)
                { Levelz(44, 176, 180); }
            }
            if (level == 10)
            {
                lev = lvl.Next(45, 50);
                resettexbox();
                if (lev == 45)
                { Levelz(45, 180, 184); }
                else if (lev == 46)
                { Levelz(46, 184, 188); }
                else if (lev == 47)
                { Levelz(47, 188, 192); }
                else if (lev == 48)
                { Levelz(48, 192, 196); }
                else if (lev == 49)
                { Levelz(49, 196, 200); }
            }
            if (level == 11)
            {
                lev = lvl.Next(50, 55);
                resettexbox();
                if (lev == 50)
                { Levelz(50, 200, 204); }
                else if (lev == 51)
                { Levelz(51, 204, 208); }
                else if (lev == 52)
                { Levelz(52, 208, 212); }
                else if (lev == 53)
                { Levelz(53, 212, 216); }
                else if (lev == 54)
                { Levelz(54, 216, 220); }
            }
            if (level == 12)
            {
                lev = lvl.Next(55, 60);
                resettexbox();
                if (lev == 55)
                { Levelz(55, 220, 224); }
                else if (lev == 56)
                { Levelz(56, 224, 228); }
                else if (lev == 57)
                { Levelz(57, 228, 232); }
                else if (lev == 58)
                { Levelz(58, 232, 236); }
                else if (lev == 59)
                { Levelz(59, 236, 240); }
            }
            if (level == 13)
            {
                lev = lvl.Next( 60, 65);
                resettexbox();
                if (lev == 60)
                { Levelz(60, 240, 244); }
                else if (lev == 61)
                { Levelz(61, 244, 248); }
                else if (lev == 62)
                { Levelz(62, 248, 252); }
                else if (lev == 63)
                { Levelz(63, 252, 256); }
                else if (lev == 64)
                { Levelz(64, 256, 260); }
            }
            if (level == 14)
            {
                lev = lvl.Next(65, 70);
                resettexbox();
                if (lev == 65)
                { Levelz(65, 260, 264); }
                else if (lev == 66)
                { Levelz(66, 264, 268); }
                else if (lev == 67)
                { Levelz(67, 268, 272); }
                else if (lev == 68)
                { Levelz(68, 272, 276); }
                else if (lev == 69)
                { Levelz(69, 276, 280); }
            }
            button3.Visible = false;
            erotisi.Play();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
           
                timer2.Stop();
                effect(level).BackColor = Color.Indigo;
                timer2.Start();
                count++;
            
             if (cd==-1)
            { timer2.Stop();
                timer1.Stop();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            timer1.Stop();
            effect(level).BackColor = Color.BlueViolet;
            timer1.Start();


        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void roloi_Tick(object sender, EventArgs e)
        {


            label16.Text = cd.ToString();
            cd--;
            if (cd == -1)
            { roloi.Stop();
                MessageBox.Show("Έχασες!");

            }


        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            switch (lev)
            {
                //level 1
                case 0:
                    CheckAnswers(textBox2,textBox3,textBox4,textBox5,0);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 1:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 4);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 2:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 8);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 3:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 12);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 4:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 16);
                    roloi.Stop();
                    cd = 20;
                    break;
                    //=========================================
                    //level 2
                case 5:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 20);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 6:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 24);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 7:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 28);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 8:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 32);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 9:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 36);
                    roloi.Stop();
                    cd = 20;
                    break;

                    //level 3

                case 10:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 40);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 11:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 44);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 12:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 48);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 13:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 52);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 14:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 56);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 4
                case 15:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 60);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 16:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 64);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 17:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 68);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 18:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 72);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 19:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 76);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 5
                case 20:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 80);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 21:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 84);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 22:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 88);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 23:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 92);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 24:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 96);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 6
                case 25:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 100);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 26:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 104);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 27:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 108);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 28:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 112);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 29:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 116);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 7
                case 30:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 120);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 31:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 124);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 32:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 128);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 33:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 132);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 34:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 136);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 8

                case 35:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 140);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 36:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 144);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 37:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 148);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 38:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 152);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 39:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 156);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 9
                case 40:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 160);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 41:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 164);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 42:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 168);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 43:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 172);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 44:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 176);
                    roloi.Stop();
                    cd = 20;
                    break;


                //level 10

                case 45:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 180);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 46:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 184);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 47:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 188);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 48:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 192);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 49:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 196);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 11
                case 50:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 200);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 51:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 204);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 52:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 208);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 53:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 212);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 54:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 216);
                    roloi.Stop();
                    cd = 20;
                    break;


                //level 12
                case 55:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 220);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 56:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 224);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 57:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 228);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 58:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 232);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 59:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 236);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 13
                case 60:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 240);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 61:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 244);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 62:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 248);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 63:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 252);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 64:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 256);
                    roloi.Stop();
                    cd = 20;
                    break;


                //level 14
                case 65:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 260);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 66:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 264);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 67:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 268);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 68:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 272);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 69:
                    CheckAnswers(textBox2, textBox3, textBox4, textBox5, 276);
                    roloi.Stop();
                    cd = 20;
                    break;




            }

            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;


        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            switch (lev)
            {
                //level 1
                case 0:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 0);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 1:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 4);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 2:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 8);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 3:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 12);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 4:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 16);
                    roloi.Stop();
                    cd = 20;
                    break;
                //=========================================
                //level 2
                case 5:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 20);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 6:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 24);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 7:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 28);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 8:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 32);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 9:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 36);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 3

                case 10:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 40);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 11:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 44);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 12:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 48);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 13:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 52);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 14:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 56);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 4
                case 15:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 60);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 16:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 64);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 17:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 68);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 18:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 72);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 19:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 76);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 5
                case 20:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 80);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 21:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 84);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 22:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 88);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 23:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 92);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 24:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 96);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 6
                case 25:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 100);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 26:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 104);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 27:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 108);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 28:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 112);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 29:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 116);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 7
                case 30:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 120);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 31:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 124);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 32:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 128);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 33:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 132);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 34:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 136);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 8

                case 35:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 140);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 36:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 144);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 37:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 148);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 38:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 152);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 39:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 156);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 9
                case 40:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 160);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 41:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 164);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 42:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 168);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 43:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 172);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 44:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 176);
                    roloi.Stop();
                    cd = 20;
                    break;


                //level 10

                case 45:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 180);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 46:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 184);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 47:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 188);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 48:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 192);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 49:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 196);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 11
                case 50:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 200);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 51:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 204);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 52:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 208);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 53:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 212);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 54:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 216);
                    roloi.Stop();
                    cd = 20;
                    break;


                //level 12
                case 55:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 220);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 56:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 224);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 57:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 228);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 58:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 232);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 59:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 236);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 13
                case 60:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 240);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 61:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 244);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 62:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 248);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 63:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 252);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 64:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 256);
                    roloi.Stop();
                    cd = 20;
                    break;


                //level 14
                case 65:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 260);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 66:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 264);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 67:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 268);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 68:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 272);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 69:
                    CheckAnswers(textBox3, textBox2, textBox4, textBox5, 276);
                    roloi.Stop();
                    cd = 20;
                    break;

            }
            textBox2.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            switch (lev)
            {
                //level 1
                case 0:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 0);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 1:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 4);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 2:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 8);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 3:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 12);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 4:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 16);
                    roloi.Stop();
                    cd = 20;
                    break;
                //=========================================
                //level 2
                case 5:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 20);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 6:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 24);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 7:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 28);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 8:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 32);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 9:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 36);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 3

                case 10:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 40);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 11:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 44);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 12:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 48);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 13:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 52);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 14:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 56);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 4
                case 15:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 60);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 16:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 64);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 17:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 68);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 18:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 72);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 19:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 76);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 5
                case 20:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 80);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 21:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 84);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 22:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 88);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 23:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 92);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 24:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 96);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 6
                case 25:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 100);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 26:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 104);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 27:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 108);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 28:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 112);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 29:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 116);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 7
                case 30:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 120);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 31:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 124);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 32:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 128);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 33:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 132);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 34:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 136);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 8

                case 35:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 140);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 36:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 144);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 37:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 148);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 38:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 152);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 39:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 156);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 9
                case 40:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 160);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 41:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 164);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 42:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 168);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 43:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 172);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 44:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 176);
                    roloi.Stop();
                    cd = 20;
                    break;


                //level 10

                case 45:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 180);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 46:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 184);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 47:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 188);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 48:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 192);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 49:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 196);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 11
                case 50:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 200);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 51:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 204);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 52:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 208);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 53:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 212);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 54:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 216);
                    roloi.Stop();
                    cd = 20;
                    break;


                //level 12
                case 55:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 220);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 56:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 224);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 57:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 228);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 58:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 232);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 59:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 236);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 13
                case 60:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 240);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 61:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 244);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 62:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 248);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 63:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 252);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 64:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 256);
                    roloi.Stop();
                    cd = 20;
                    break;


                //level 14
                case 65:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 260);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 66:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 264);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 67:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 268);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 68:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 272);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 69:
                    CheckAnswers(textBox4, textBox3, textBox2, textBox5, 276);
                    roloi.Stop();
                    cd = 20;
                    break;

            }
            textBox3.Enabled = false;
            textBox2.Enabled = false;
            textBox5.Enabled = false;
        }

        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {
            switch (lev)
            {
                //level 1
                case 0:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 0);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 1:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 4);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 2:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 8);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 3:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 12);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 4:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 16);
                    roloi.Stop();
                    cd = 20;
                    break;
                //=========================================
                //level 2
                case 5:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 20);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 6:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 24);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 7:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 28);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 8:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 32);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 9:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 36);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 3

                case 10:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 40);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 11:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 44);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 12:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 48);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 13:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 52);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 14:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 56);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 4
                case 15:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 60);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 16:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 64);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 17:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 68);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 18:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 72);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 19:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 76);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 5
                case 20:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 80);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 21:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 84);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 22:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 88);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 23:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 92);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 24:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 96);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 6
                case 25:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 100);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 26:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 104);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 27:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 108);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 28:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 112);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 29:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 116);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 7
                case 30:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 120);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 31:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 124);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 32:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 128);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 33:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 132);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 34:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 136);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 8

                case 35:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 140);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 36:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 144);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 37:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 148);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 38:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 152);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 39:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 156);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 9
                case 40:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 160);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 41:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 164);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 42:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 168);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 43:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 172);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 44:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 176);
                    roloi.Stop();
                    cd = 20;
                    break;


                //level 10

                case 45:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 180);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 46:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 184);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 47:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 188);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 48:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 192);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 49:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 196);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 11
                case 50:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 200);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 51:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 204);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 52:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 208);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 53:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 212);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 54:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 216);
                    roloi.Stop();
                    cd = 20;
                    break;


                //level 12
                case 55:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 220);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 56:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 224);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 57:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 228);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 58:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 232);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 59:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 236);
                    roloi.Stop();
                    cd = 20;
                    break;

                //level 13
                case 60:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 240);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 61:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 244);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 62:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 248);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 63:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 252);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 64:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 256);
                    roloi.Stop();
                    cd = 20;
                    break;


                //level 14
                case 65:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 260);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 66:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 264);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 67:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 268);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 68:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 272);
                    roloi.Stop();
                    cd = 20;
                    break;

                case 69:
                    CheckAnswers(textBox5, textBox3, textBox4, textBox2, 276);
                    roloi.Stop();
                    cd = 20;
                    break;
            }
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (lev)
            {
                //level 1
                case 0:
                    fiftyfifty(0);
                    break;
                case 1:
                    fiftyfifty(4);
                    break;
                case 2:
                    fiftyfifty(8);
                    break;
                case 3:
                    fiftyfifty(12);
                    break;
                case 4:
                    fiftyfifty(16);
                    break;

                    //level 2
                case 5:
                    fiftyfifty(20);
                    break;
                case 6:
                    fiftyfifty(24);
                    break;
                case 7:
                    fiftyfifty(28);
                    break;
                case 8:
                    fiftyfifty(32);
                    break;
                case 9:
                    fiftyfifty(36);
                    break;

                    //level 3
                case 10:
                    fiftyfifty(40);
                    break;
                case 11:
                    fiftyfifty(44);
                    break;
                case 12:
                    fiftyfifty(48);
                    break;
                case 13:
                    fiftyfifty(52);
                    break;
                case 14:
                    fiftyfifty(56);
                    break;

                    //level 4
                case 15:
                    fiftyfifty(60);
                    break;

                case 16:
                    fiftyfifty(64);
                    break;
                case 17:
                    fiftyfifty(68);
                    break;
                case 18:
                    fiftyfifty(72);
                    break;
                case 19:
                    fiftyfifty(76);
                    break;

                    //level 5
                case 20:
                    fiftyfifty(80);
                    break;
                case 21:
                    fiftyfifty(84);
                    break;
                case 22:
                    fiftyfifty(88);
                    break;
                case 23:
                    fiftyfifty(92);
                    break;
                case 24:
                    fiftyfifty(96);
                    break;

                    //level 6
                case 25:
                    fiftyfifty(100);
                    break;
                case 26:
                    fiftyfifty(104);
                    break;
                case 27:
                    fiftyfifty(108);
                    break;
                case 28:
                    fiftyfifty(112);
                    break;
                case 29:
                    fiftyfifty(116);
                    break;

                    //level 7
                case 30:
                    fiftyfifty(120);
                    break;
                case 31:
                    fiftyfifty(124);
                    break;
                case 32:
                    fiftyfifty(128);
                    break;
                case 33:
                    fiftyfifty(132);
                    break;
                case 34:
                    fiftyfifty(136);
                    break;

                    //level 8
                case 35:
                    fiftyfifty(140);
                    break;
                case 36:
                    fiftyfifty(144);
                    break;
                case 37:
                    fiftyfifty(148);
                    break;
                case 38:
                    fiftyfifty(152);
                    break;
                case 39:
                    fiftyfifty(156);
                    break;

                    //level 9
                case 40:
                    fiftyfifty(160);
                    break;
                case 41:
                    fiftyfifty(164);
                    break;
                case 42:
                    fiftyfifty(168);
                    break;
                case 43:
                    fiftyfifty(172);
                    break;
                case 44:
                    fiftyfifty(176);
                    break;

                //level 10
                case 45:
                    fiftyfifty(180);
                    break;
                case 46:
                    fiftyfifty(184);
                    break;
                case 47:
                    fiftyfifty(188);
                    break;
                case 48:
                    fiftyfifty(192);
                    break;
                case 49:
                    fiftyfifty(196);
                    break;

                //level 11
                case 50:
                    fiftyfifty(200);
                    break;
                case 51:
                    fiftyfifty(204);
                    break;
                case 52:
                    fiftyfifty(208);
                    break;
                case 53:
                    fiftyfifty(212);
                    break;
                case 54:
                    fiftyfifty(216);
                    break;


                //level 12
                case 55:
                    fiftyfifty(220);
                    break;
                case 56:
                    fiftyfifty(224);
                    break;
                case 57:
                    fiftyfifty(228);
                    break;
                case 58:
                    fiftyfifty(232);
                    break;
                case 59:
                    fiftyfifty(236);
                    break;


                //level 13
                case 60:
                    fiftyfifty(240);
                    break;
                case 61:
                    fiftyfifty(244);
                    break;
                case 62:
                    fiftyfifty(248);
                    break;
                case 63:
                    fiftyfifty(252);
                    break;
                case 64:
                    fiftyfifty(256);
                    break;

                //level 14
                case 65:
                    fiftyfifty(260);
                    break;
                case 66:
                    fiftyfifty(264);
                    break;
                case 67:
                    fiftyfifty(268);
                    break;
                case 68:
                    fiftyfifty(272);
                    break;
                case 69:
                    fiftyfifty(276);
                    break;

            }
            _50_50.Play();
        }

        public void fiftyfifty(int x)
        {
            if (textBox2.Text.ToString() == level1answers[x])
            {
                do
                {
                    leva = 0;
                    leva1 = 0;
                    leva = lvla.Next(1, 4);
                    leva1 = lvla.Next(1, 4);
                    if (leva != leva1)
                    { break; }
                } while (true);

                if (leva == 1)
                {
                    textBox3.Visible = false;
                    label18.Visible = false;

                }
                else if (leva == 2)
                { textBox4.Visible = false;
                    label19.Visible = false;
                }
                else if (leva == 3)
                { textBox5.Visible = false;
                    label20.Visible = false;
                }

                if (leva1 == 1)
                {
                    textBox3.Visible = false;
                    label18.Visible = false;
                }
                else if (leva1 == 2)
                { textBox4.Visible = false;
                    label19.Visible = false;
                }
                else if (leva1 == 3)
                { textBox5.Visible = false;
                    label20.Visible = false;
                }
            }
            else if (textBox3.Text.ToString() == level1answers[x])
            {
                do
                {
                    leva = 0;
                    leva1 = 0;
                    leva = lvla.Next(1, 4);
                    leva1 = lvla.Next(1, 4);
                    if (leva != leva1)
                    { break; }
                } while (true);

                if (leva == 1)
                {
                    textBox2.Visible = false;
                    label17.Visible = false;
                }
                else if (leva == 2)
                { textBox4.Visible = false;
                    label19.Visible = false;
                }
                else if (leva == 3)
                { textBox5.Visible = false;
                    label20.Visible = false;
                }

                if (leva1 == 1)
                {
                    textBox2.Visible = false;
                    label17.Visible = false;
                }
                else if (leva1 == 2)
                { textBox4.Visible = false;
                    label19.Visible = false;
                }
                else if (leva1 == 3)
                { textBox5.Visible = false;
                    label20.Visible = false;
                }
            }
            else if (textBox4.Text.ToString() == level1answers[x])
            {
                do
                {
                    leva = 0;
                    leva1 = 0;
                    leva = lvla.Next(1, 4);
                    leva1 = lvla.Next(1, 4);
                    if (leva != leva1)
                    { break; }
                } while (true);

                if (leva == 1)
                {
                    textBox3.Visible = false;
                    label18.Visible = false;
                }
                else if (leva == 2)
                { textBox2.Visible = false;
                    label17.Visible = false;
                }
                else if (leva == 3)
                { textBox5.Visible = false;
                    label20.Visible = false;
                }

                if (leva1 == 1)
                {
                    textBox3.Visible = false;
                    label18.Visible = false;
                }
                else if (leva1 == 2)
                { textBox2.Visible = false;
                    label17.Visible = false;
                }
                else if (leva1 == 3)
                { textBox5.Visible = false;
                    label20.Visible = false;
                }
            }
            if (textBox5.Text.ToString() == level1answers[x])
            {
                do
                {
                    leva = 0;
                    leva1 = 0;
                    leva = lvla.Next(1, 4);
                    leva1 = lvla.Next(1, 4);
                    if (leva != leva1)
                    { break; }
                } while (true);

                if (leva == 1)
                {
                    textBox3.Visible = false;
                    label18.Visible = false;
                }
                else if (leva == 2)
                { textBox4.Visible = false;
                    label19.Visible = false;
                }
                else if (leva == 3)
                { textBox2.Visible = false;
                    label17.Visible = false;
                }

                if (leva1 == 1)
                {
                    textBox3.Visible = false;
                    label18.Visible = false;
                }
                else if (leva1 == 2)
                { textBox4.Visible = false;
                    label19.Visible = false;
                }
                else if (leva1 == 3)
                { textBox2.Visible = false;
                    label17.Visible = false;
                }
            }

            button1.Enabled = false;
            button1.BackgroundImage = Properties.Resources.Classic5050used;
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            //do
            //{
            //    num1 = num.Next(75, 86);
            //    num2 = num.Next(7, 11);
            //    num3 = num.Next(6, 11);
            //    num4 = num.Next(2, 6);
            //    if (num1 + num2 + num3 + num4 == 100)
            //        break;
            //}
            //while (true);
            
           
            leva = 0;
            leva1 = 0;
            leva2 = 0;
            leva3 = 0;

            //============================================
            switch (lev)
            {
                //level 1
                case 0:
                    Audience(0,75,86,7,11,6,11,2,6);
                    break;
                case 1:
                    Audience(4, 75, 86, 7, 11, 6, 11, 2, 6);
                    break;
                case 2:
                    Audience(8, 75, 86, 7, 11, 6, 11, 2, 6);
                    break;
                case 3:
                    Audience(12, 75, 86, 7, 11, 6, 11, 2, 6);
                    break;
                case 4:
                    Audience(16, 75, 86, 7, 11, 6, 11, 2, 6);
                    break;

                //level 2
                case 5:
                    Audience(20, 75, 86, 7, 11, 6, 11, 2, 6);
                    break;
                case 6:
                    Audience(24, 75, 86, 7, 11, 6, 11, 2, 6);
                    break;
                case 7:
                    Audience(28, 75, 86, 7, 11, 6, 11, 2, 6);
                    break;
                case 8:
                    Audience(32, 75, 86, 7, 11, 6, 11, 2, 6);
                    break;
                case 9:
                    Audience(36, 75, 86, 7, 11, 6, 11, 2, 6);
                    break;

                //level 3
                case 10:
                    Audience(40, 75, 86, 7, 11, 6, 11, 2, 6);
                    break;
                case 11:
                    Audience(44, 75, 86, 7, 11, 6, 11, 2, 6);
                    break;
                case 12:
                    Audience(48, 75, 86, 7, 11, 6, 11, 2, 6);
                    break;
                case 13:
                    Audience(52, 75, 86, 7, 11, 6, 11, 2, 6);
                    break;
                case 14:
                    Audience(56, 75, 86, 7, 11, 6, 11, 2, 6);
                    break;

                //level 4
                case 15:
                    Audience(60,60,75,11,15,10,20,4,5);
                    break;

                case 16:
                    Audience(64, 60, 75, 11, 15, 10, 20, 4, 5);
                    break;
                case 17:
                    Audience(68, 60, 75, 11, 15, 10, 20, 4, 5);
                    break;
                case 18:
                    Audience(72, 60, 75, 11, 15, 10, 20, 4, 5);
                    break;
                case 19:
                    Audience(76, 60, 75, 11, 15, 10, 20, 4, 5);
                    break;

                //level 5
                case 20:
                    Audience(80, 60, 75, 11, 15, 10, 20, 4, 5);
                    break;
                case 21:
                    Audience(84, 60, 75, 11, 15, 10, 20, 4, 5);
                    break;
                case 22:
                    Audience(88, 60, 75, 11, 15, 10, 20, 4, 5);
                    break;
                case 23:
                    Audience(92, 60, 75, 11, 15, 10, 20, 4, 5);
                    break;
                case 24:
                    Audience(96, 60, 75, 11, 15, 10, 20, 4, 5);
                    break;

                //level 6
                case 25:
                    Audience(100, 60, 75, 11, 15, 10, 20, 4, 5);
                    break;
                case 26:
                    Audience(104, 60, 75, 11, 15, 10, 20, 4, 5);
                    break;
                case 27:
                    Audience(108, 60, 75, 11, 15, 10, 20, 4, 5);
                    break;
                case 28:
                    Audience(112, 60, 75, 11, 15, 10, 20, 4, 5);
                    break;
                case 29:
                    Audience(116, 60, 75, 11, 15, 10, 20, 4, 5);
                    break;

                //level 7
                case 30:
                    Audience(120,50,60,20,30,10,12,8,10);
                    break;
                case 31:
                    Audience(124, 50, 60, 20, 30, 10, 12, 8, 10);
                    break;
                case 32:
                    Audience(128, 50, 60, 20, 30, 10, 12, 8, 10);
                    break;
                case 33:
                    Audience(132, 50, 60, 20, 30, 10, 12, 8, 10);
                    break;
                case 34:
                    Audience(136, 50, 60, 20, 30, 10, 12, 8, 10);
                    break;

                //level 8
                case 35:
                    Audience(140, 50, 60, 20, 30, 10, 12, 8, 10);
                    break;
                case 36:
                    Audience(144, 50, 60, 20, 30, 10, 12, 8, 10);
                    break;
                case 37:
                    Audience(148, 50, 60, 20, 30, 10, 12, 8, 10);
                    break;
                case 38:
                    Audience(152, 50, 60, 20, 30, 10, 12, 8, 10);
                    break;
                case 39:
                    Audience(156, 50, 60, 20, 30, 10, 12, 8, 10);
                    break;

                //level 9
                case 40:
                    Audience(160, 50, 60, 20, 30, 10, 12, 8, 10);
                    break;
                case 41:
                    Audience(164, 50, 60, 20, 30, 10, 12, 8, 10);
                    break;
                case 42:
                    Audience(168, 50, 60, 20, 30, 10, 12, 8, 10);
                    break;
                case 43:
                    Audience(172, 50, 60, 20, 30, 10, 12, 8, 10);
                    break;
                case 44:
                    Audience(176, 50, 60, 20, 30, 10, 12, 8, 10);
                    break;

                //level 10
                case 45:
                    Audience(180,50,55,20,30,11,20,5,9);
                    break;
                case 46:
                    Audience(184, 50, 55, 20, 30, 11, 20, 5, 9);
                    break;
                case 47:
                    Audience(188, 50, 55, 20, 30, 11, 20, 5, 9);
                    break;
                case 48:
                    Audience(192, 50, 55, 20, 30, 11, 20, 5, 9);
                    break;
                case 49:
                    Audience(196, 50, 55, 20, 30, 11, 20, 5, 9);
                    break;

                //level 11
                case 50:
                    Audience(200, 50, 55, 20, 30, 11, 20, 5, 9);
                    break;
                case 51:
                    Audience(204, 50, 55, 20, 30, 11, 20, 5, 9);
                    break;
                case 52:
                    Audience(208, 50, 55, 20, 30, 11, 20, 5, 9);
                    break;
                case 53:
                    Audience(212, 50, 55, 20, 30, 11, 20, 5, 9);
                    break;
                case 54:
                    Audience(216, 50, 55, 20, 30, 11, 20, 5, 9);
                    break;


                //level 12
                case 55:
                    Audience(220, 50, 55, 20, 30, 11, 20, 5, 9);
                    break;
                case 56:
                    Audience(224, 50, 55, 20, 30, 11, 20, 5, 9);
                    break;
                case 57:
                    Audience(228, 50, 55, 20, 30, 11, 20, 5, 9);
                    break;
                case 58:
                    Audience(232, 50, 55, 20, 30, 11, 20, 5, 9);
                    break;
                case 59:
                    Audience(236, 50, 55, 20, 30, 11, 20, 5, 9);
                    break;


                //level 13
                case 60:
                    Audience(240,40,50,30,40,15,17,3,5);
                    break;
                case 61:
                    Audience(244, 40, 50, 30, 40, 15, 17, 3, 5);
                    break;
                case 62:
                    Audience(248, 40, 50, 30, 40, 15, 17, 3, 5);
                    break;
                case 63:
                    Audience(252, 40, 50, 30, 40, 15, 17, 3, 5);
                    break;
                case 64:
                    Audience(256, 40, 50, 30, 40, 15, 17, 3, 5);
                    break;

                //level 14
                case 65:
                    Audience(260, 40, 50, 30, 40, 15, 17, 3, 5);
                    break;
                case 66:
                    Audience(264, 40, 50, 30, 40, 15, 17, 3, 5);
                    break;
                case 67:
                    Audience(268, 40, 50, 30, 40, 15, 17, 3, 5);
                    break;
                case 68:
                    Audience(272, 40, 50, 30, 40, 15, 17, 3, 5);
                    break;
                case 69:
                    Audience(276, 40, 50, 30, 40, 15, 17, 3, 5);
                    break;

            }
            //===========================================

            chart1.Series["Series1"].ChartArea = "ChartArea1";
            chartxy.Start();
            audienceSound.Play();

            button2.Enabled = false;


        }
      

        private void chartxy_Tick(object sender, EventArgs e)
        {
            chartcount++;
            if(chartcount==5)
            { chart1.Visible = false;
                chartxy.Stop();
                audienceSound.Stop();
            }
            
        }

        public void CheckAnswers(TextBox w,TextBox y,TextBox q,TextBox z, int x)
        {
            if (w.Text.ToString() == level1answers[x])
            {
                w.BackColor = Color.Green;
               
                effect(level).BackColor = Color.Gold;
                effect(level).ForeColor = Color.Black;
                level++;
                richtig.Play();
                button3.Visible = true;
                button3.Text = "Επόμενη ερώτηση";
                if (level==15)
                { button7.Visible = true;
                    MessageBox.Show("ΣΥΓΧΑΡΗΤΗΡΙΑ ΕΙΣΑΙ ΕΚΚΑΤΟΜΥΡΙΟΥΧΟΣ!!!");
                }
            }
            else
            { w.BackColor = Color.Red;
                effect(level).BackColor = Color.Transparent;
                effect(level).ForeColor = Color.LightSalmon;
               // falsch.Play();
            }


            if (y.Text.ToString() == level1answers[x])

            { y.BackColor = Color.Green;
                timer2.Stop();
                timer1.Stop();
                effect(level).BackColor = Color.Transparent;
                effect(level).ForeColor = Color.LightSalmon;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Visible = false;
                 roloi.Stop();
                falsch.Play();
               ok(level);
                MessageBox.Show("Κέρδισες "+label22.Text);
                button6.Enabled = false;
                button4.Enabled = false;



            }
            if (q.Text.ToString() == level1answers[x])
            { q.BackColor = Color.Green;
                timer2.Stop();
                timer1.Stop();
                effect(level).BackColor = Color.Transparent;
                effect(level).ForeColor = Color.LightSalmon;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Visible = false;
                 roloi.Stop();
                falsch.Play();
               ok(level);
                MessageBox.Show("Κέρδισες " + label22.Text);
                button6.Enabled = false;
                button4.Enabled = false;


            }
            if (z.Text.ToString() == level1answers[x])
            { z.BackColor = Color.Green;
                timer2.Stop();
                timer1.Stop();
                effect(level).BackColor = Color.Transparent;
                effect(level).ForeColor = Color.LightSalmon;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Visible = false;
                roloi.Stop();
                falsch.Play();
               ok(level);
                MessageBox.Show("Κέρδισες " + label22.Text);
                button6.Enabled = false;
                button4.Enabled = false;
            }


        }

        public void Audience(int y, int a, int b, int c, int d,int e,int f,int g,int h)
        {
          
            do
            {
                num1 = num.Next(a, b);
                num2 = num.Next(c, d);
                num3 = num.Next(e, f);
                num4 = num.Next(g, h);
                if (num1 + num2 + num3 + num4 == 100)
                    break;
            }

            while (true);


            if (textBox2.Text.ToString() == level1answers[y])
            {
                chart1.Series["Series1"].Points.AddXY("A", num1);
                chart1.Series["Series1"].Points.AddXY("Β", num2);
                chart1.Series["Series1"].Points.AddXY("Γ", num3);
                chart1.Series["Series1"].Points.AddXY("Δ", num4);
                chart1.Visible = true;
            }


            if (textBox3.Text.ToString() == level1answers[y])

            {
                chart1.Series["Series1"].Points.AddXY("A", num2);
                chart1.Series["Series1"].Points.AddXY("Β", num1);
                chart1.Series["Series1"].Points.AddXY("Γ", num3);
                chart1.Series["Series1"].Points.AddXY("Δ", num4);
                chart1.Visible = true;
            }
            if (textBox4.Text.ToString() == level1answers[y])
            {
                chart1.Series["Series1"].Points.AddXY("A", num3);
                chart1.Series["Series1"].Points.AddXY("Β", num2);
                chart1.Series["Series1"].Points.AddXY("Γ", num1);
                chart1.Series["Series1"].Points.AddXY("Δ", num4);
                chart1.Visible = true;
            }
            if (textBox5.Text.ToString() == level1answers[y])
            {
                chart1.Series["Series1"].Points.AddXY("A", num4);
                chart1.Series["Series1"].Points.AddXY("Β", num2);
                chart1.Series["Series1"].Points.AddXY("Γ", num3);
                chart1.Series["Series1"].Points.AddXY("Δ", num1);
                chart1.Visible = true;
            }
            
            button2.Enabled = false;
            button2.BackgroundImage = Properties.Resources.ClassicATAused;
        }

        public void ResetLabels()
        {
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
        }

        public void Levelz(int x, int f, int g)
        {
           
                do
                {
                    leva = f;
                    leva1 = f;
                    leva2 = f;
                    leva3 = f;
                    leva = lvla.Next(f, g);
                    leva1 = lvla.Next(f, g);
                    leva2 = lvla.Next(f, g);
                    leva3 = lvla.Next(f,g);
                    if (leva != leva1 && leva != leva2 && leva != leva3 && leva1 != leva2 && leva1 != leva3 && leva2 != leva3)
                    { break; }
                }
                while (true);
                textBox1.Text = level1[x].ToString();
                textBox2.Text = level1answers[leva].ToString();
                textBox3.Text = level1answers[leva1].ToString();
                textBox4.Text = level1answers[leva2].ToString();
                textBox5.Text = level1answers[leva3].ToString();
                  
                roloi.Start();
                timer1.Start();
    }

        public Label effect(int x)
        {   
            if(x==0)
            { return label22; }
            else if (x == 1)
            {
                return label15;
            }
           else if (x == 2)
            {
                return label14;
            }
            else if (x == 3)
            {
                return label13;
            }
            else if (x == 4)
            {
                return label12;
            }
            else if (x == 5)
            {
                return label11;
            }
            else if (x == 6)
            {
                return label10;
            }
            else if (x == 7)
            {
                return label9;
            }
            else if (x == 8)
            {
                return label8;
            }
            else if (x == 9)
            {
                return label7;
            }
            else if (x == 10)
            {
                return label6;
            }
            else if (x == 11)
            {
                return label5;
            }
            else if (x == 12)
            {
                return label4;
            }
            else if (x == 13)
            {
                return label3;
            }
            else { return label2; }
        }

        public void resettexbox()
        {
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;

            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox5.Visible = true;
            textBox4.Visible = true;

            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox5.Enabled = true;
            textBox4.Enabled = true;
            textBox2.BackColor = Color.MidnightBlue;
            textBox3.BackColor = Color.MidnightBlue;
            textBox4.BackColor = Color.MidnightBlue;
            textBox5.BackColor = Color.MidnightBlue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (onoff == 0)
            {
                pictureBox1.Visible = true;
              //  ok(level);
                label21.Text = effect(level - 1).Text.ToString();
                onoff = 1;
            }
            else if (onoff == 1)
            {
             
              pictureBox1.Visible = false;
                onoff = 0;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ok(int x)
        {
            if (effect(x) == label15)
            { label22.Text = label22.Text; }
            else if (effect(x) == label14)
            { label22.Text = label22.Text; }
            else if (effect(x) == label13)
            { label22.Text = label22.Text; }
            else if (effect(x) == label12)
            { label22.Text = label22.Text; }

            else if (effect(x) == label11)
            { label22.Text = label12.Text; }
            else if (effect(x) == label10)
            { label22.Text = label12.Text; }
            else if (effect(x) == label9)
            { label22.Text = label12.Text; }
            else if (effect(x) == label8)
            { label22.Text = label12.Text; }
            else if (effect(x) == label7)
            { label22.Text = label12.Text; }

            else if (effect(x) == label6)
            { label22.Text = label7.Text; }
            else if (effect(x) == label5)
            { label22.Text = label7.Text; }
            else if (effect(x) == label4)
            { label22.Text = label7.Text; }
            else if (effect(x) == label3)
            { label22.Text = label7.Text; }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label21.Text = effect(level - 1).Text.ToString();
            MessageBox.Show("Συγχαρητήρια!!! " + label21.Text + " είναι δικά σου!!!");
            Application.Exit();
        }
    }
}
