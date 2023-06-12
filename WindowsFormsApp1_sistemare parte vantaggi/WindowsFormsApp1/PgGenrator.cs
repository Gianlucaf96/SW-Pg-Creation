using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    class pgGenerator
    {
        List<int> dado = new List<int> { 1, 2, 2, 2, 2, 3, 3, 3, 4, };
        List<int> Tuttofare = new List<int> { 3, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        List<int> Equilibrato = new List<int> { 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 3, 3, 3};
        List<int> Specializzato = new List<int> { 1, 1, 1, 2, 2, 2, 3, 3, 3, 4};
        List<int> PowerValue = new List<int> { 0, 1, 2 };
        public List<string[]> StatAssegnate = new List<string[]>();
        public List<string[]> AbilitàAssegnate = new List<string[]>(); 
        string[] Nome = { "Aaran", "Aaren", "Aarez", "Aarman", "Aaron", "Aaron-James", "Aarron", "Aaryan", "Aaryn", "Aayan", "Aazaan", "Abaan", "Abbas", "Abdallah", "Abdalroof", "Abdihakim", "Abdirahman", "Abdisalam", "Abdul", "Abdul-Aziz", "Abdulbasir", "Abdulkadir", "Abdulkarem", "Abdulkhader", "Abdullah", "Abdul-Majeed", "Abdulmalik", "Abdul-Rehman", "Abdur", "Abdurraheem", "Abdur-Rahman", "Abdur-Rehmaan", "Abel", "Abhinav", "Abhisumant", "Abid", "Abir", "Abraham", "Abu", "Abubakar", "Ace", "Adain", "Adam", "Adam-James", "Addison", "Addisson", "Adegbola", "Adegbolahan", "Aden", "Adenn", "Adie", "Adil", "Aditya", "Adnan", "Adrian", "Adrien", "Aedan", "Aedin", "Aedyn", "Aeron", "Afonso", "Ahmad", "Ahmed", "Ahmed-Aziz", "Ahoua", "Ahtasham", "Aiadan", "Aidan", "Aiden", "Aiden-Jack", "Aiden-Vee", "Aidian", "Aidy", "Ailin", "Aiman", "Ainsley", "Ainslie", "Airen", "Airidas", "Airlie", "AJ", "Ajay", "A-Jay", "Ajayraj", "Akan", "Akram", "Al", "Ala", "Alan", "Alanas", "Alasdair", "Alastair", "Alber", "Albert", "Albie", "Aldred", "Alec", "Aled", "Aleem", "Aleksandar", "Aleksander", "Aleksandr", "Aleksandrs", "Alekzander", "Alessandro", "Alessio", "Alex", "Alexander", "Alexei", "Alexx", "Alexzander", "Alf", "Alfee", "Alfie", "Alfred", "Alfy", "Alhaji", "Al-Hassan", "Ali", "Aliekber", "Alieu", "Alihaider", "Alisdair", "Alishan", "Alistair", "Alistar", "Alister", "Aliyaan", "Allan", "Allan-Laiton", "Allen", "Allesandro", "Allister", "Ally", "Alphonse", "Altyiab", "Alum", "Alvern", "Alvin", "Alyas", "Amaan", "Aman", "Amani", "Ambanimoh", "Ameer", "Amgad", "Ami", "Amin", "Amir", "Ammaar", "Ammar", "Ammer", "Amolpreet", "Amos", "Amrinder", "Amrit", "Amro", "Anay", "Andrea", "Andreas", "Andrei", "Andrejs", "Andrew", "Andy", "Anees", "Anesu", "Angel", "Angelo", "Angus", "Anir", "Anis", "Anish", "Anmolpreet", "Annan", "Anndra", "Anselm", "Anthony", "Anthony-John", "Antoine", "Anton", "Antoni", "Antonio", "Antony", "Antonyo", "Anubhav", "Aodhan", "Aon", "Aonghus", "Apisai", "Arafat", "Aran", "Arandeep", "Arann", "Aray", "Arayan", "Archibald", "Archie", "Arda", "Ardal", "Ardeshir", "Areeb", "Areez", "Aref", "Arfin", "Argyle", "Argyll", "Ari", "Aria", "Arian", "Arihant", "Aristomenis", "Aristotelis", "Arjuna", "Arlo", "Armaan", "Arman", "Armen", "Arnab", "Arnav", "Arnold", "Aron", "Aronas", "Arran", "Arrham", "Arron", "Arryn", "Arsalan", "Artem", "Arthur", "Artur", "Arturo", "Arun", "Arunas", "Arved", "Arya", "Aryan", "Aryankhan", "Aryian", "Aryn", "Asa", "Asfhan", "Ash", "Ashlee-jay", "Ashley", "Ashton", "Ashton-Lloyd", "Ashtyn", "Ashwin", "Asif", "Asim", "Aslam", "Asrar", "Ata", "Atal", "Atapattu", "Ateeq", "Athol", "Athon", "Athos-Carlos", "Atli", "Atom", "Attila", "Aulay", "Aun", "Austen", "Austin", "Avani", "Averon", "Avi", "Avinash", "Avraham", "Awais", "Awwal", "Axel", "Ayaan", "Ayan", "Aydan", "Ayden", "Aydin", "Aydon", "Ayman", "Ayomide", "Ayren", "Ayrton", "Aytug", "Ayub", "Ayyub", "Azaan", "Azedine", "Azeem", "Azim", "Aziz", "Azlan", "Azzam", "Azzedine", "Babatunmise", "Babur", "Bader", "Badr", "Badsha", "Bailee", "Bailey", "Bailie", "Bailley", "Baillie", "Baley", "Balian", "Banan", "Barath", "Barkley", "Barney", "Baron", "Barrie", "Barry", "Bartlomiej", "Bartosz", "Basher", "Basile", "Baxter", "Baye", "Bayley", "Beau", "Beinn", "Bekim", "Believe", "Ben", "Bendeguz", "Benedict", "Benjamin", "Benjamyn", "Benji", "Benn", "Bennett", "Benny", "Benoit", "Bentley", "Berkay", "Bernard", "Bertie", "Bevin", "Bezalel", "Bhaaldeen", "Bharath", "Bilal", "Bill", "Billy", "Binod", "Bjorn", "Blaike", "Blaine", "Blair", "Blaire", "Blake", "Blazej", "Blazey", "Blessing", "Blue", "Blyth", "Bo", "Boab", "Bob", "Bobby", "Bobby-Lee", "Bodhan", "Boedyn", "Bogdan", "Bohbi", "Bony", "Bowen", "Bowie", "Boyd", "Bracken", "Brad", "Bradan", "Braden", "Bradley", "Bradlie", "Bradly", "Brady", "Bradyn", "Braeden", "Braiden", "Brajan", "Brandan", "Branden", "Brandon", "Brandonlee", "Brandon-Lee", "Brandyn", "Brannan", "Brayden", "Braydon", "Braydyn", "Breandan", "Brehme", "Brendan", "Brendon", "Brendyn", "Breogan", "Bret", "Brett", "Briaddon", "Brian", "Brodi", "Brodie", "Brody", "Brogan", "Broghan", "Brooke", "Brooklin", "Brooklyn", "Bruce", "Bruin", "Bruno", "Brunon", "Bryan", "Bryce", "Bryden", "Brydon", "Brydon-Craig", "Bryn", "Brynmor", "Bryson", "Buddy", "Bully", "Burak", "Burhan", "Butali", "Butchi", "Byron", "Cabhan", "Cadan", "Cade", "Caden", "Cadon", "Cadyn", "Caedan", "Caedyn", "Cael", "Caelan", "Caelen", "Caethan", "Cahl", "Cahlum", "Cai", "Caidan", "Caiden", "Caiden-Paul", "Caidyn", "Caie", "Cailaen", "Cailean", "Caileb-John", "Cailin", "Cain", "Caine", "Cairn", "Cal", "Calan", "Calder", "Cale", "Calean", "Caleb", "Calen", "Caley", "Calib", "Calin", "Callahan", "Callan", "Callan-Adam", "Calley", "Callie", "Callin", "Callum", "Callun", "Callyn", "Calum", "Calum-James", "Calvin", "Cambell", "Camerin", "Cameron", "Campbel", "Campbell", "Camron", "Caolain", "Caolan", "Carl", "Carlo", "Carlos", "Carrich", "Carrick", "Carson", "Carter", "Carwyn", "Casey", "Casper", "Cassy", "Cathal", "Cator", "Cavan", "Cayden", "Cayden-Robert", "Cayden-Tiamo", "Ceejay", "Ceilan", "Ceiran", "Ceirin", "Ceiron", "Cejay", "Celik", "Cephas", "Cesar", "Cesare", "Chad", "Chaitanya", "Chang-Ha", "Charles", "Charley", "Charlie", "Charly", "Chase", "Che", "Chester", "Chevy", "Chi", "Chibudom", "Chidera", "Chimsom", "Chin", "Chintu", "Chiqal", "Chiron", "Chris", "Chris-Daniel", "Chrismedi", "Christian", "Christie", "Christoph", "Christopher", "Christopher-Lee", "Christy", "Chu", "Chukwuemeka", "Cian", "Ciann", "Ciar", "Ciaran", "Ciarian", "Cieran", "Cillian", "Cillin", "Cinar", "CJ", "C-Jay", "Clark", "Clarke", "Clayton", "Clement", "Clifford", "Clyde", "Cobain", "Coban", "Coben", "Cobi", "Cobie", "Coby", "Codey", "Codi", "Codie", "Cody", "Cody-Lee", "Coel", "Cohan", "Cohen", "Colby", "Cole", "Colin", "Coll", "Colm", "Colt", "Colton", "Colum", "Colvin", "Comghan", "Conal", "Conall", "Conan", "Conar", "Conghaile", "Conlan", "Conley", "Conli", "Conlin", "Conlly", "Conlon", "Conlyn", "Connal", "Connall", "Connan", "Connar", "Connel", "Connell", "Conner", "Connolly", "Connor", "Connor-David", "Conor", "Conrad", "Cooper", "Copeland", "Coray", "Corben", "Corbin", "Corey", "Corey-James", "Corey-Jay", "Cori", "Corie", "Corin", "Cormac", "Cormack", "Cormak", "Corran", "Corrie", "Cory", "Cosmo", "Coupar", "Craig", "Craig-James", "Crawford", "Creag", "Crispin", "Cristian", "Crombie", "Cruiz", "Cruz", "Cuillin", "Cullen", "Cullin", "Curtis", "Cyrus", "Daanyaal", "Daegan", "Daegyu", "Dafydd", "Dagon", "Dailey", "Daimhin", "Daithi", "Dakota", "Daksh", "Dale", "Dalong", "Dalton", "Damian", "Damien", "Damon", "Dan", "Danar", "Dane", "Danial", "Daniel", "Daniele", "Daniel-James", "Daniels", "Daniil", "Danish", "Daniyal", "Danniel", "Danny", "Dante", "Danyal", "Danyil", "Danys", "Daood", "Dara", "Darach", "Daragh", "Darcy", "D'arcy", "Dareh", "Daren", "Darien", "Darius", "Darl", "Darn", "Darrach", "Darragh", "Darrel", "Darrell", "Darren", "Darrie", "Darrius", "Darroch", "Darryl", "Darryn", "Darwyn", "Daryl", "Daryn", "Daud", "Daumantas", "Davi", "David", "David-Jay", "David-Lee", "Davie", "Davis", "Davy", "Dawid", "Dawson", "Dawud", "Dayem", "Daymian", "Deacon", "Deagan", "Dean", "Deano", "Decklan", "Declain", "Declan", "Declyan", "Declyn", "Dedeniseoluwa", "Deecan", "Deegan", "Deelan", "Deklain-Jaimes", "Del", "Demetrius", "Denis", "Deniss", "Dennan", "Dennin", "Dennis", "Denny", "Dennys", "Denon", "Denton", "Denver", "Denzel", "Deon", "Derek", "Derick", "Derin", "Dermot", "Derren", "Derrie", "Derrin", "Derron", "Derry", "Derryn", "Deryn", "Deshawn", "Desmond", "Dev", "Devan", "Devin", "Devlin", "Devlyn", "Devon", "Devrin", "Devyn", "Dex", "Dexter", "Dhani", "Dharam", "Dhavid", "Dhyia", "Diarmaid", "Diarmid", "Diarmuid", "Didier", "Diego", "Diesel", "Diesil", "Digby", "Dilan", "Dilano", "Dillan", "Dillon", "Dilraj", "Dimitri", "Dinaras", "Dion", "Dissanayake", "Dmitri", "Doire", "Dolan", "Domanic", "Domenico", "Domhnall", "Dominic", "Dominick", "Dominik", "Donald", "Donnacha", "Donnie", "Dorian", "Dougal", "Douglas", "Dougray", "Drakeo", "Dre", "Dregan", "Drew", "Dugald", "Duncan", "Duriel", "Dustin", "Dylan", "Dylan-Jack", "Dylan-James", "Dylan-John", "Dylan-Patrick", "Dylin", "Dyllan", "Dyllan-James", "Dyllon", "Eadie", "Eagann", "Eamon", "Eamonn", "Eason", "Eassan", "Easton", "Ebow", "Ed", "Eddie", "Eden", "Ediomi", "Edison", "Eduardo", "Eduards", "Edward", "Edwin", "Edwyn", "Eesa", "Efan", "Efe", "Ege", "Ehsan", "Ehsen", "Eiddon", "Eidhan", "Eihli", "Eimantas", "Eisa", "Eli", "Elias", "Elijah", "Eliot", "Elisau", "Eljay", "Eljon", "Elliot", "Elliott", "Ellis", "Ellisandro", "Elshan", "Elvin", "Elyan", "Emanuel", "Emerson", "Emil", "Emile", "Emir", "Emlyn", "Emmanuel", "Emmet", "Eng", "Eniola", "Enis", "Ennis", "Enrico", "Enrique", "Enzo", "Eoghain", "Eoghan", "Eoin", "Eonan", "Erdehan", "Eren", "Erencem", "Eric", "Ericlee", "Erik", "Eriz", "Ernie-Jacks", "Eroni", "Eryk", "Eshan", "Essa", "Esteban", "Ethan", "Etienne", "Etinosa", "Euan", "Eugene", "Evan", "Evann", "Ewan", "Ewen", "Ewing", "Exodi", "Ezekiel", "Ezra", "Fabian", "Fahad", "Faheem", "Faisal", "Faizaan", "Famara", "Fares", "Farhaan", "Farhan", "Farren", "Farzad", "Fauzaan", "Favour", "Fawaz", "Fawkes", "Faysal", "Fearghus", "Feden", "Felix", "Fergal", "Fergie", "Fergus", "Ferre", "Fezaan", "Fiachra", "Fikret", "Filip", "Filippo", "Finan", "Findlay", "Findlay-James", "Findlie", "Finlay", "Finley", "Finn", "Finnan", "Finnean", "Finnen", "Finnlay", "Finnley", "Fintan", "Fionn", "Firaaz", "Fletcher", "Flint", "Florin", "Flyn", "Flynn", "Fodeba", "Folarinwa", "Forbes", "Forgan", "Forrest", "Fox", "Francesco", "Francis", "Francisco", "Franciszek", "Franco", "Frank", "Frankie", "Franklin", "Franko", "Fraser", "Frazer", "Fred", "Freddie", "Frederick", "Fruin", "Fyfe", "Fyn", "Fynlay", "Fynn", "Gabriel", "Gallagher", "Gareth", "Garren", "Garrett", "Garry", "Gary", "Gavin", "Gavin-Lee", "Gene", "Geoff", "Geoffrey", "Geomer", "Geordan", "Geordie", "George", "Georgia", "Georgy", "Gerard", "Ghyll", "Giacomo", "Gian", "Giancarlo", "Gianluca", "Gianmarco", "Gideon", "Gil", "Gio", "Girijan", "Girius", "Gjan", "Glascott", "Glen", "Glenn", "Gordon", "Grady", "Graeme", "Graham", "Grahame", "Grant", "Grayson", "Greg", "Gregor", "Gregory", "Greig", "Griffin", "Griffyn", "Grzegorz", "Guang", "Guerin", "Guillaume", "Gurardass", "Gurdeep", "Gursees", "Gurthar", "Gurveer", "Gurwinder", "Gus", "Gustav", "Guthrie", "Guy", "Gytis", "Habeeb", "Hadji", "Hadyn", "Hagun", "Haiden", "Haider", "Hamad", "Hamid", "Hamish", "Hamza", "Hamzah", "Han", "Hansen", "Hao", "Hareem", "Hari", "Harikrishna", "Haris", "Harish", "Harjeevan", "Harjyot", "Harlee", "Harleigh", "Harley", "Harman", "Harnek", "Harold", "Haroon", "Harper", "Harri", "Harrington", "Harris", "Harrison", "Harry", "Harvey", "Harvie", "Harvinder", "Hasan", "Haseeb", "Hashem", "Hashim", "Hassan", "Hassanali", "Hately", "Havila", "Hayden", "Haydn", "Haydon", "Haydyn", "Hcen", "Hector", "Heddle", "Heidar", "Heini", "Hendri", "Henri", "Henry", "Herbert", "Heyden", "Hiro", "Hirvaansh", "Hishaam", "Hogan", "Honey", "Hong", "Hope", "Hopkin", "Hosea", "Howard", "Howie", "Hristomir", "Hubert", "Hugh", "Hugo", "Humza", "Hunter", "Husnain", "Hussain", "Hussan", "Hussnain", "Hussnan", "Hyden", "I", "Iagan", "Iain", "Ian", "Ibraheem", "Ibrahim", "Idahosa", "Idrees", "Idris", "Iestyn", "Ieuan", "Igor", "Ihtisham", "Ijay", "Ikechukwu", "Ikemsinachukwu", "Ilyaas", "Ilyas", "Iman", "Immanuel", "Inan", "Indy", "Ines", "Innes", "Ioannis", "Ireayomide", "Ireoluwa", "Irvin", "Irvine", "Isa", "Isaa", "Isaac", "Isaiah", "Isak", "Isher", "Ishwar", "Isimeli", "Isira", "Ismaeel", "Ismail", "Israel", "Issiaka", "Ivan", "Ivar", "Izaak", "J", "Jaay", "Jac", "Jace", "Jack", "Jacki", "Jackie", "Jack-James", "Jackson", "Jacky", "Jacob", "Jacques", "Jad", "Jaden", "Jadon", "Jadyn", "Jae", "Jagat", "Jago", "Jaheim", "Jahid", "Jahy", "Jai", "Jaida", "Jaiden", "Jaidyn", "Jaii", "Jaime", "Jai-Rajaram", "Jaise", "Jak", "Jake", "Jakey", "Jakob", "Jaksyn", "Jakub", "Jamaal", "Jamal", "Jameel", "Jameil", "James", "James-Paul", "Jamey", "Jamie", "Jan", "Jaosha", "Jardine", "Jared", "Jarell", "Jarl", "Jarno", "Jarred", "Jarvi", "Jasey-Jay", "Jasim", "Jaskaran", "Jason", "Jasper", "Jaxon", "Jaxson", "Jay", "Jaydan", "Jayden", "Jayden-James", "Jayden-Lee", "Jayden-Paul", "Jayden-Thomas", "Jaydn", "Jaydon", "Jaydyn", "Jayhan", "Jay-Jay", "Jayke", "Jaymie", "Jayse", "Jayson", "Jaz", "Jazeb", "Jazib", "Jazz", "Jean", "Jean-Lewis", "Jean-Pierre", "Jebadiah", "Jed", "Jedd", "Jedidiah", "Jeemie", "Jeevan", "Jeffrey", "Jensen", "Jenson", "Jensyn", "Jeremy", "Jerome", "Jeronimo", "Jerrick", "Jerry", "Jesse", "Jesuseun", "Jeswin", "Jevan", "Jeyun", "Jez", "Jia", "Jian", "Jiao", "Jimmy", "Jincheng", "JJ", "Joaquin", "Joash", "Jock", "Jody", "Joe", "Joeddy", "Joel", "Joey", "Joey-Jack", "Johann", "Johannes", "Johansson", "John", "Johnathan", "Johndean", "Johnjay", "John-Michael", "Johnnie", "Johnny", "Johnpaul", "John-Paul", "John-Scott", "Johnson", "Jole", "Jomuel", "Jon", "Jonah", "Jonatan", "Jonathan", "Jonathon", "Jonny", "Jonothan", "Jon-Paul", "Jonson", "Joojo", "Jordan", "Jordi", "Jordon", "Jordy", "Jordyn", "Jorge", "Joris", "Jorryn", "Josan", "Josef", "Joseph", "Josese", "Josh", "Joshiah", "Joshua", "Josiah", "Joss", "Jostelle", "Joynul", "Juan", "Jubin", "Judah", "Jude", "Jules", "Julian", "Julien", "Jun", "Junior", "Jura", "Justan", "Justin", "Justinas", "Kaan", "Kabeer", "Kabir", "Kacey", "Kacper", "Kade", "Kaden", "Kadin", "Kadyn", "Kaeden", "Kael", "Kaelan", "Kaelin", "Kaelum", "Kai", "Kaid", "Kaidan", "Kaiden", "Kaidinn", "Kaidyn", "Kaileb", "Kailin", "Kain", "Kaine", "Kainin", "Kainui", "Kairn", "Kaison", "Kaiwen", "Kajally", "Kajetan", "Kalani", "Kale", "Kaleb", "Kaleem", "Kal-el", "Kalen", "Kalin", "Kallan", "Kallin", "Kalum", "Kalvin", "Kalvyn", "Kameron", "Kames", "Kamil", "Kamran", "Kamron", "Kane", "Karam", "Karamvir", "Karandeep", "Kareem", "Karim", "Karimas", "Karl", "Karol", "Karson", "Karsyn", "Karthikeya", "Kasey", "Kash", "Kashif", "Kasim", "Kasper", "Kasra", "Kavin", "Kayam", "Kaydan", "Kayden", "Kaydin", "Kaydn", "Kaydyn", "Kaydyne", "Kayleb", "Kaylem", "Kaylum", "Kayne", "Kaywan", "Kealan", "Kealon", "Kean", "Keane", "Kearney", "Keatin", "Keaton", "Keavan", "Keayn", "Kedrick", "Keegan", "Keelan", "Keelin", "Keeman", "Keenan", "Keenan-Lee", "Keeton", "Kehinde", "Keigan", "Keilan", "Keir", "Keiran", "Keiren", "Keiron", "Keiryn", "Keison", "Keith", "Keivlin", "Kelam", "Kelan", "Kellan", "Kellen", "Kelso", "Kelum", "Kelvan", "Kelvin", "Ken", "Kenan", "Kendall", "Kendyn", "Kenlin", "Kenneth", "Kensey", "Kenton", "Kenyon", "Kenzeigh", "Kenzi", "Kenzie", "Kenzo", "Kenzy", "Keo", "Ker", "Kern", "Kerr", "Kevan", "Kevin", "Kevyn", "Kez", "Khai", "Khalan", "Khaleel", "Khaya", "Khevien", "Khizar", "Khizer", "Kia", "Kian", "Kian-James", "Kiaran", "Kiarash", "Kie", "Kiefer", "Kiegan", "Kienan", "Kier", "Kieran", "Kieran-Scott", "Kieren", "Kierin", "Kiern", "Kieron", "Kieryn", "Kile", "Killian", "Kimi", "Kingston", "Kinneil", "Kinnon", "Kinsey", "Kiran", "Kirk", "Kirwin", "Kit", "Kiya", "Kiyonari", "Kjae", "Klein", "Klevis", "Kobe", "Kobi", "Koby", "Koddi", "Koden", "Kodi", "Kodie", "Kody", "Kofi", "Kogan", "Kohen", "Kole", "Konan", "Konar", "Konnor", "Konrad", "Koray", "Korben", "Korbyn", "Korey", "Kori", "Korrin", "Kory", "Koushik", "Kris", "Krish", "Krishan", "Kriss", "Kristian", "Kristin", "Kristofer", "Kristoffer", "Kristopher", "Kruz", "Krzysiek", "Krzysztof", "Ksawery", "Ksawier", "Kuba", "Kurt", "Kurtis", "Kurtis-Jae", "Kyaan", "Kyan", "Kyde", "Kyden", "Kye", "Kyel", "Kyhran", "Kyie", "Kylan", "Kylar", "Kyle", "Kyle-Derek", "Kylian", "Kym", "Kynan", "Kyral", "Kyran", "Kyren", "Kyrillos", "Kyro", "Kyron", "Kyrran", "Lachlainn", "Lachlan", "Lachlann", "Lael", "Lagan", "Laird", "Laison", "Lakshya", "Lance", "Lancelot", "Landon", "Lang", "Lasse", "Latif", "Lauchlan", "Lauchlin", "Laughlan", "Lauren", "Laurence", "Laurie", "Lawlyn", "Lawrence", "Lawrie", "Lawson", "Layne", "Layton", "Lee", "Leigh", "Leigham", "Leighton", "Leilan", "Leiten", "Leithen", "Leland", "Lenin", "Lennan", "Lennen", "Lennex", "Lennon", "Lennox", "Lenny", "Leno", "Lenon", "Lenyn", "Leo", "Leon", "Leonard", "Leonardas", "Leonardo", "Lepeng", "Leroy", "Leven", "Levi", "Levon", "Levy", "Lewie", "Lewin", "Lewis", "Lex", "Leydon", "Leyland", "Leylann", "Leyton", "Liall", "Liam", "Liam-Stephen", "Limo", "Lincoln", "Lincoln-John", "Lincon", "Linden", "Linton", "Lionel", "Lisandro", "Litrell", "Liyonela-Elam", "LLeyton", "Lliam", "Lloyd", "Lloyde", "Loche", "Lochlan", "Lochlann", "Lochlan-Oliver", "Lock", "Lockey", "Logan", "Logann", "Logan-Rhys", "Loghan", "Lokesh", "Loki", "Lomond", "Lorcan", "Lorenz", "Lorenzo", "Lorne", "Loudon", "Loui", "Louie", "Louis", "Loukas", "Lovell", "Luc", "Luca", "Lucais", "Lucas", "Lucca", "Lucian", "Luciano", "Lucien", "Lucus", "Luic", "Luis", "Luk", "Luka", "Lukas", "Lukasz", "Luke", "Lukmaan", "Luqman", "Lyall", "Lyle", "Lyndsay", "Lysander", "Maanav", "Maaz", "Mac", "Macallum", "Macaulay", "Macauley", "Macaully", "Machlan", "Maciej", "Mack", "Mackenzie", "Mackenzy", "Mackie", "Macsen", "Macy", "Madaki", "Maddison", "Maddox", "Madison", "Madison-Jake", "Madox", "Mael", "Magnus", "Mahan", "Mahdi", "Mahmoud", "Maias", "Maison", "Maisum", "Maitlind", "Majid", "Makensie", "Makenzie", "Makin", "Maksim", "Maksymilian", "Malachai", "Malachi", "Malachy", "Malakai", "Malakhy", "Malcolm", "Malik", "Malikye", "Malo", "Ma'moon", "Manas", "Maneet", "Manmohan", "Manolo", "Manson", "Mantej", "Manuel", "Manus", "Marc", "Marc-Anthony", "Marcel", "Marcello", "Marcin", "Marco", "Marcos", "Marcous", "Marcquis", "Marcus", "Mario", "Marios", "Marius", "Mark", "Marko", "Markus", "Marley", "Marlin", "Marlon", "Maros", "Marshall", "Martin", "Marty", "Martyn", "Marvellous", "Marvin", "Marwan", "Maryk", "Marzuq", "Mashhood", "Mason", "Mason-Jay", "Masood", "Masson", "Matas", "Matej", "Mateusz", "Mathew", "Mathias", "Mathu", "Mathuyan", "Mati", "Matt", "Matteo", "Matthew", "Matthew-William", "Matthias", "Max", "Maxim", "Maximilian", "Maximillian", "Maximus", "Maxwell", "Maxx", "Mayeul", "Mayson", "Mazin", "Mcbride", "McCaulley", "McKade", "McKauley", "McKay", "McKenzie", "McLay", "Meftah", "Mehmet", "Mehraz", "Meko", "Melville", "Meshach", "Meyzhward", "Micah", "Michael", "Michael-Alexander", "Michael-James", "Michal", "Michat", "Micheal", "Michee", "Mickey", "Miguel", "Mika", "Mikael", "Mikee", "Mikey", "Mikhail", "Mikolaj", "Miles", "Millar", "Miller", "Milo", "Milos", "Milosz", "Mir", "Mirza", "Mitch", "Mitchel", "Mitchell", "Moad", "Moayd", "Mobeen", "Modoulamin", "Modu", "Mohamad", "Mohamed", "Mohammad", "Mohammad-Bilal", "Mohammed", "Mohanad", "Mohd", "Momin", "Momooreoluwa", "Montague", "Montgomery", "Monty", "Moore", "Moosa", "Moray", "Morgan", "Morgyn", "Morris", "Morton", "Moshy", "Motade", "Moyes", "Msughter", "Mueez", "Muhamadjavad", "Muhammad", "Muhammed", "Muhsin", "Muir", "Munachi", "Muneeb", "Mungo", "Munir", "Munmair", "Munro", "Murdo", "Murray", "Murrough", "Murry", "Musa", "Musse", "Mustafa", "Mustapha", "Muzammil", "Muzzammil", "Mykie", "Myles", "Mylo", "Nabeel", "Nadeem", "Nader", "Nagib", "Naif", "Nairn", "Narvic", "Nash", "Nasser", "Nassir", "Natan", "Nate", "Nathan", "Nathanael", "Nathanial", "Nathaniel", "Nathan-Rae", "Nawfal", "Nayan", "Neco", "Neil", "Nelson", "Neo", "Neshawn", "Nevan", "Nevin", "Ngonidzashe", "Nial", "Niall", "Nicholas", "Nick", "Nickhill", "Nicki", "Nickson", "Nicky", "Nico", "Nicodemus", "Nicol", "Nicolae", "Nicolas", "Nidhish", "Nihaal", "Nihal", "Nikash", "Nikhil", "Niki", "Nikita", "Nikodem", "Nikolai", "Nikos", "Nilav", "Niraj", "Niro", "Niven", "Noah", "Noel", "Nolan", "Noor", "Norman", "Norrie", "Nuada", "Nyah", "Oakley", "Oban", "Obieluem", "Obosa", "Odhran", "Odin", "Odynn", "Ogheneochuko", "Ogheneruno", "Ohran", "Oilibhear", "Oisin", "Ojima-Ojo", "Okeoghene", "Olaf", "Ola-Oluwa", "Olaoluwapolorimi", "Ole", "Olie", "Oliver", "Olivier", "Oliwier", "Ollie", "Olurotimi", "Oluwadamilare", "Oluwadamiloju", "Oluwafemi", "Oluwafikunayomi", "Oluwalayomi", "Oluwatobiloba", "Oluwatoni", "Omar", "Omri", "Oran", "Orin", "Orlando", "Orley", "Orran", "Orrick", "Orrin", "Orson", "Oryn", "Oscar", "Osesenagha", "Oskar", "Ossian", "Oswald", "Otto", "Owain", "Owais", "Owen", "Owyn", "Oz", "Ozzy", "Pablo", "Pacey", "Padraig", "Paolo", "Pardeepraj", "Parkash", "Parker", "Pascoe", "Pasquale", "Patrick", "Patrick-John", "Patrikas", "Patryk", "Paul", "Pavit", "Pawel", "Pawlo", "Pearce", "Pearse", "Pearsen", "Pedram", "Pedro", "Peirce", "Peiyan", "Pele", "Peni", "Peregrine", "Peter", "Phani", "Philip", "Philippos", "Phinehas", "Phoenix", "Phoevos", "Pierce", "Pierre-Antoine", "Pieter", "Pietro", "Piotr", "Porter", "Prabhjoit", "Prabodhan", "Praise", "Pranav", "Pravin", "Precious", "Prentice", "Presley", "Preston", "Preston-Jay", "Prinay", "Prince", "Prithvi", "Promise", "Puneetpaul", "Pushkar", "Qasim", "Qirui", "Quinlan", "Quinn", "Radmiras", "Raees", "Raegan", "Rafael", "Rafal", "Rafferty", "Rafi", "Raheem", "Rahil", "Rahim", "Rahman", "Raith", "Raithin", "Raja", "Rajab-Ali", "Rajan", "Ralfs", "Ralph", "Ramanas", "Ramit", "Ramone", "Ramsay", "Ramsey", "Rana", "Ranolph", "Raphael", "Rasmus", "Rasul", "Raul", "Raunaq", "Ravin", "Ray", "Rayaan", "Rayan", "Rayane", "Rayden", "Rayhan", "Raymond", "Rayne", "Rayyan", "Raza", "Reace", "Reagan", "Reean", "Reece", "Reed", "Reegan", "Rees", "Reese", "Reeve", "Regan", "Regean", "Reggie", "Rehaan", "Rehan", "Reice", "Reid", "Reigan", "Reilly", "Reily", "Reis", "Reiss", "Remigiusz", "Remo", "Remy", "Ren", "Renars", "Reng", "Rennie", "Reno", "Reo", "Reuben", "Rexford", "Reynold", "Rhein", "Rheo", "Rhett", "Rheyden", "Rhian", "Rhoan", "Rholmark", "Rhoridh", "Rhuairidh", "Rhuan", "Rhuaridh", "Rhudi", "Rhy", "Rhyan", "Rhyley", "Rhyon", "Rhys", "Rhys-Bernard", "Rhyse", "Riach", "Rian", "Ricards", "Riccardo", "Ricco", "Rice", "Richard", "Richey", "Richie", "Ricky", "Rico", "Ridley", "Ridwan", "Rihab", "Rihan", "Rihards", "Rihonn", "Rikki", "Riley", "Rio", "Rioden", "Rishi", "Ritchie", "Rivan", "Riyadh", "Riyaj", "Roan", "Roark", "Roary", "Rob", "Robbi", "Robbie", "Robbie-lee", "Robby", "Robert", "Robert-Gordon", "Robertjohn", "Robi", "Robin", "Rocco", "Roddy", "Roderick", "Rodrigo", "Roen", "Rogan", "Roger", "Rohaan", "Rohan", "Rohin", "Rohit", "Rokas", "Roman", "Ronald", "Ronan", "Ronan-Benedict", "Ronin", "Ronnie", "Rooke", "Roray", "Rori", "Rorie", "Rory", "Roshan", "Ross", "Ross-Andrew", "Rossi", "Rowan", "Rowen", "Roy", "Ruadhan", "Ruaidhri", "Ruairi", "Ruairidh", "Ruan", "Ruaraidh", "Ruari", "Ruaridh", "Ruben", "Rubhan", "Rubin", "Rubyn", "Rudi", "Rudy", "Rufus", "Rui", "Ruo", "Rupert", "Ruslan", "Russel", "Russell", "Ryaan", "Ryan", "Ryan-Lee", "Ryden", "Ryder", "Ryese", "Ryhs", "Rylan", "Rylay", "Rylee", "Ryleigh", "Ryley", "Rylie", "Ryo", "Ryszard", "Saad", "Sabeen", "Sachkirat", "Saffi", "Saghun", "Sahaib", "Sahbian", "Sahil", "Saif", "Saifaddine", "Saim", "Sajid", "Sajjad", "Salahudin", "Salman", "Salter", "Salvador", "Sam", "Saman", "Samar", "Samarjit", "Samatar", "Sambrid", "Sameer", "Sami", "Samir", "Sami-Ullah", "Samual", "Samuel", "Samuela", "Samy", "Sanaullah", "Sandro", "Sandy", "Sanfur", "Sanjay", "Santiago", "Santino", "Satveer", "Saul", "Saunders", "Savin", "Sayad", "Sayeed", "Sayf", "Scot", "Scott", "Scott-Alexander", "Seaan", "Seamas", "Seamus", "Sean", "Seane", "Sean-James", "Sean-Paul", "Sean-Ray", "Seb", "Sebastian", "Sebastien", "Selasi", "Seonaidh", "Sephiroth", "Sergei", "Sergio", "Seth", "Sethu", "Seumas", "Shaarvin", "Shadow", "Shae", "Shahmir", "Shai", "Shane", "Shannon", "Sharland", "Sharoz", "Shaughn", "Shaun", "Shaunpaul", "Shaun-Paul", "Shaun-Thomas", "Shaurya", "Shaw", "Shawn", "Shawnpaul", "Shay", "Shayaan", "Shayan", "Shaye", "Shayne", "Shazil", "Shea", "Sheafan", "Sheigh", "Shenuk", "Sher", "Shergo", "Sheriff", "Sherwyn", "Shiloh", "Shiraz", "Shreeram", "Shreyas", "Shyam", "Siddhant", "Siddharth", "Sidharth", "Sidney", "Siergiej", "Silas", "Simon", "Sinai", "Skye", "Sofian", "Sohaib", "Sohail", "Soham", "Sohan", "Sol", "Solomon", "Sonneey", "Sonni", "Sonny", "Sorley", "Soul", "Spencer", "Spondon", "Stanislaw", "Stanley", "Stefan", "Stefano", "Stefin", "Stephen", "Stephenjunior", "Steve", "Steven", "Steven-lee", "Stevie", "Stewart", "Stewarty", "Strachan", "Struan", "Stuart", "Su", "Subhaan", "Sudais", "Suheyb", "Suilven", "Sukhi", "Sukhpal", "Sukhvir", "Sulayman", "Sullivan", "Sultan", "Sung", "Sunny", "Suraj", "Surien", "Sweyn", "Syed", "Sylvain", "Symon", "Szymon", "Tadd", "Taddy", "Tadhg", "Taegan", "Taegen", "Tai", "Tait", "Taiwo", "Talha", "Taliesin", "Talon", "Talorcan", "Tamar", "Tamiem", "Tammam", "Tanay", "Tane", "Tanner", "Tanvir", "Tanzeel", "Taonga", "Tarik", "Tariq-Jay", "Tate", "Taylan", "Taylar", "Tayler", "Taylor", "Taylor-Jay", "Taylor-Lee", "Tayo", "Tayyab", "Tayye", "Tayyib", "Teagan", "Tee", "Teejay", "Tee-jay", "Tegan", "Teighen", "Teiyib", "Te-Jay", "Temba", "Teo", "Teodor", "Teos", "Terry", "Teydren", "Theo", "Theodore", "Thiago", "Thierry", "Thom", "Thomas", "Thomas-Jay", "Thomson", "Thorben", "Thorfinn", "Thrinei", "Thumbiko", "Tiago", "Tian", "Tiarnan", "Tibet", "Tieran", "Tiernan", "Timothy", "Timucin", "Tiree", "Tisloh", "Titi", "Titus", "Tiylar", "TJ", "Tjay", "T-Jay", "Tobey", "Tobi", "Tobias", "Tobie", "Toby", "Todd", "Tokinaga", "Toluwalase", "Tom", "Tomas", "Tomasz", "Tommi-Lee", "Tommy", "Tomson", "Tony", "Torin", "Torquil", "Torran", "Torrin", "Torsten", "Trafford", "Trai", "Travis", "Tre", "Trent", "Trey", "Tristain", "Tristan", "Troy", "Tubagus", "Turki", "Turner", "Ty", "Ty-Alexander", "Tye", "Tyelor", "Tylar", "Tyler", "Tyler-James", "Tyler-Jay", "Tyllor", "Tylor", "Tymom", "Tymon", "Tymoteusz", "Tyra", "Tyree", "Tyrnan", "Tyrone", "Tyson", "Ubaid", "Ubayd", "Uchenna", "Uilleam", "Umair", "Umar", "Umer", "Umut", "Urban", "Uri", "Usman", "Uzair", "Uzayr", "Valen", "Valentin", "Valentino", "Valery", "Valo", "Vasyl", "Vedantsinh", "Veeran", "Victor", "Victory", "Vinay", "Vince", "Vincent", "Vincenzo", "Vinh", "Vinnie", "Vithujan", "Vladimir", "Vladislav", "Vrishin", "Vuyolwethu", "Wabuya", "Wai", "Walid", "Wallace", "Walter", "Waqaas", "Warkhas", "Warren", "Warrick", "Wasif", "Wayde", "Wayne", "Wei", "Wen", "Wesley", "Wesley-Scott", "Wiktor", "Wilkie", "Will", "William", "William-John", "Willum", "Wilson", "Windsor", "Wojciech", "Woyenbrakemi", "Wyatt", "Wylie", "Wynn", "Xabier", "Xander", "Xavier", "Xiao", "Xida", "Xin", "Xue", "Yadgor", "Yago", "Yahya", "Yakup", "Yang", "Yanick", "Yann", "Yannick", "Yaseen", "Yasin", "Yasir", "Yassin", "Yoji", "Yong", "Yoolgeun", "Yorgos", "Youcef", "Yousif", "Youssef", "Yu", "Yuanyu", "Yuri", "Yusef", "Yusuf", "Yves", "Zaaine", "Zaak", "Zac", "Zach", "Zachariah", "Zacharias", "Zacharie", "Zacharius", "Zachariya", "Zachary", "Zachary-Marc", "Zachery", "Zack", "Zackary", "Zaid", "Zain", "Zaine", "Zaineddine", "Zainedin", "Zak", "Zakaria", "Zakariya", "Zakary", "Zaki", "Zakir", "Zakk", "Zamaar", "Zander", "Zane", "Zarran", "Zayd", "Zayn", "Zayne", "Ze", "Zechariah", "Zeek", "Zeeshan", "Zeid", "Zein", "Zen", "Zendel", "Zenith", "Zennon", "Zeph", "Zerah", "Zhen", "Zhi", "Zhong", "Zhuo", "Zi", "Zidane", "Zijie", "Zinedine", "Zion", "Zishan", "Ziya", "Ziyaan", "Zohaib", "Zohair", "Zoubaeir", "Zubair", "Zubayr", "Zurie", "Aurora", "Beatrice", "Benedetta", "Bianca", "Camilla", "Carlotta", "Caterina", "Chiara", "Cinzia", "Clara", "Cristina", "Daniela", "Debora", "Elena", "Eleonora", "Elisa", "Emma", "Erica", "Federica", "Flavia", "Francesca", "Gabriella", "Giada", "Giorgia", "Giulia", "Greta", "Ilaria", "Isabella", "Laura", "Linda", "Ludovica", "Maddalena", "Manuela", "Mara", "Margherita", "Maria", "Marianna", "Marika", "Martina", "Matilde", "Michela", "Monica", "Nadia", "Nicole", "Paola", "Patrizia", "Raffaella", "Rebecca", "Roberta", "Rossella", "Sabrina", "Samantha", "Sara", "Serena", "Silvia", "Simona", "Stefania", "Susanna", "Tania", "Tatiana", "Valentina", "Vanessa", "Veronica", "Vittoria", "Anders", "Arne", "Asbjørn", "Bjørn", "Christian", "Einar", "Eirik", "Espen", "Even", "Fredrik", "Gunnar", "Håkon", "Harald", "Jan", "Johan", "Jon", "Kjell", "Lars", "Leif", "Magnus", "Marius", "Mats", "Morten", "Nils", "Ole", "Ola", "Olav", "Oskar", "Pål", "Per", "Petter", "Roar", "Rune", "Sander", "Svein", "Sven", "Tobias", "Tommy", "Trond", "Øivind", "Åge", "Åsmund", "Andreas", "Arvid", "Audun", "Bendik", "Børge", "Daniel", "Edvard", "Erlend", "Frank", "Gard", "Geir", "Gjermund", "Hans", "Henrik", "Inge", "Isak", "Jens", "Joakim", "Jørgen", "Karl", "Kjetil", "Ludvig", "Magnus", "Martin", "Mikkel", "Nikolai", "Odd", "Oskar", "Peder", "Pål", "Robert", "Roy", "Ruben", "Sigurd", "Sondre", "Stian", "Sverre", "Terje", "Thomas", "Tomas", "Torbjørn", "Vetle", "William", "Øystein", "Adrian", "Aleksander", "Alexander", "André", "Arne", "Benjamin", "Dennis", "Erik", "Espen", "Even", "Filip", "Fredrik", "Gunnar", "Håkon", "Harald", "Henrikke", "Ingrid", "Iselin", "Janne", "Jenny", "Johanne", "Julie", "Kari", "Kjersti", "Lene", "Linda", "Linn", "Lisa", "Maren", "Maria", "Marit", "Martine", "May", "Mette", "Mia", "Nina", "Oda", "Oline", "Pernille", "Sara", "Selma", "Sigrun", "Siri", "Siv", "Sofie", "Sol", "Solveig", "Susanne", "Synne", "Thea", "Therese", "Tone", "Tonje", "Trine", "Vibeke", "Victoria", "Alexander", "Andreas", "Anton", "Benjamin", "Christian", "Daniel", "David", "Dominik", "Emil", "Erik", "Fabian", "Felix", "Florian", "Frank", "Frederik", "Gabriel", "Georg", "Gregor", "Hannes", "Hans", "Heinrich", "Helmut", "Henning", "Henrik", "Herbert", "Holger", "Jan", "Johannes", "Jonas", "Jonathan", "Josef", "Jürgen", "Karl", "Klaus", "Konstantin", "Leif", "Lennart", "Ludwig", "Manfred", "Marco", "Markus", "Martin", "Matthias", "Max", "Michael", "Moritz", "Nico", "Niklas", "Nils", "Oliver", "Paul", "Peter", "Philipp", "Rainer", "Reinhard", "Reinhold", "Richard", "Robert", "Roland", "Rudolf", "Sebastian", "Simon", "Stefan", "Sven", "Theo", "Thomas", "Timo", "Tobias", "Udo", "Ulrich", "Uwe", "Valentin", "Volker", "Werner", "Wilhelm", "Wolfgang", "Xaver", "Yannick", "Yves", "Zacharias", "Zeno", "Andreas", "Axel", "Ben", "Benno", "Bernd", "Carsten", "Christoph", "David", "Denis", "Dirk", "Dominik", "Eckart", "Eduard", "Elias", "Emil", "Ernst", "Felix", "Ferdinand", "Florian", "Adam", "Adrien", "Alexandre", "Antoine", "Arnaud", "Arthur", "Aurélien", "Benjamin", "Benoît", "Boris", "Camille", "Cédric", "Charles", "Clément", "Damien", "David", "Denis", "Didier", "Dorian", "Edouard", "Elie", "Elio", "Emile", "Emmanuel", "Etienne", "Fabien", "Franck", "François", "Gabriel", "Gaël", "Gaspard", "Geoffroy", "Gilles", "Grégoire", "Guillaume", "Hector", "Henri", "Hugo", "Isaac", "Jacques", "Jean", "Jérémie", "Julien", "Kevin", "Léo", "Léonard", "Louis", "Luc", "Lucas", "Ludovic", "Marc", "Marcel", "Martin", "Mathieu", "Maxence", "Michel", "Nathan", "Nicolas", "Olivier", "Pascal", "Patrick", "Paul", "Philippe", "Pierre", "Quentin", "Raphaël", "Raymond", "René", "Richard", "Robert", "Romain", "Sébastien", "Stéphane", "Théo", "Thibaut", "Thibault", "Thomas", "Timothée", "Tristan", "Valentin", "Victor", "Vincent", "Xavier", "Yann", "Yoann", "Yves", "Zacharie", "Adeline", "Agathe", "Agnès", "Alexandra", "Alice", "Aline", "Amélie", "Anaïs", "Andréa", "Anne", "Aude", "Aurélie", "Béatrice", "Bérénice", "Brigitte", "Camille", "Carine", "Carole", "Catherine", "Cécile", "Chantal", "Charlotte", "Chloé", "Christelle", "Christiane", "Christine", "Claire", "Claudine", "Colette", "Corinne", "Danièle", "Delphine", "Dominique", "Edith", "Eléonore", "Elisabeth", "Elsa", "Emeline", "Emilie", "Estelle", "Eve", "Fabienne", "Fanny", "Florence", "Françoise", "Gabrielle", "Geneviève", "Géraldine", "Germaine", "Gisèle", "Hélène", "Henriette", "Inès", "Isabelle", "Jacqueline", "Jocelyne", "Joëlle", "Josette", "Josiane", "Julie", "Justine", "Laure", "Léa", "Liliane", "Louise", "Lucie", "Madeleine", "Magali", "Manon", "Margaux", "Marguerite", "Marie", "Marianne", "Marie-Anne", "Marie-France", "Adelheid", "Agnes", "Alexandra", "Alice", "Alina", "Amalia", "Amelie", "Anastasia", "Andrea", "Angelika", "Anita", "Anna", "Anneliese", "Annika", "Antonia", "Astrid", "Augusta", "Barbara", "Beate", "Bettina", "Bianca", "Brigitte", "Carina", "Carla", "Carmen", "Caroline", "Christa", "Christiane", "Christin", "Christina", "Claudia", "Conny", "Corinna", "Cornelia", "Dagmar", "Daniela", "Diana", "Doris", "Edith", "Elena", "Elisabeth", "Ellen", "Elsa", "Emilia", "Emma", "Erica" };
        string[] Cognome = { "Rossi", "Ferrari", "Ricci", "Bruno", "Lombardi", "Romano", "Longo", "Gallo", "Marino", "Greco", "Moretti", "Conti", "Silva", "Pellegrini", "Cavalli", "Esposito", "Marchetti", "Colombo", "Gentile", "Santoro", "Hansen", "Johansen", "Olsen", "Larsen", "Andersen", "Pedersen", "Nilsen", "Kristiansen", "Jakobsen", "Thomsen", "Eriksen", "Pettersen", "Berg", "Sørensen", "Gundersen", "Moen", "Haugen", "Haugland", "Hagen", "Lunde", "Müller", "Schmidt", "Schneider", "Fischer", "Weber", "Wagner", "Becker", "Hoffmann", "Schäfer", "Koch", "Bauer", "Richter", "Klein", "Schroeder", "Neumann", "Schwarz", "Zimmermann", "Braun", "Krüger", "Hofmann", "Dupont", "Martin", "Bernard", "Dubois", "Durand", "Moreau", "Lefevre", "Girard", "Roux", "Clement", "Blanc", "Gauthier", "Rousseau", "Fontaine", "Andre", "Muller", "Fournier", "Lemaire", "Mathieu", "Mercier", "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson", "Moore", "Taylor", "Anderson", "Jackson", "Thompson", "White", "Harris", "Clark", "Lewis", "Young", "Allen", "Scott", "Smith", "Jones", "Taylor", "Brown", "Wilson", "Johnson", "Davies", "Robinson", "Wright", "Thompson", "Evans", "Walker", "White", "Green", "Hall", "Lewis", "Baker", "King", "Carter", "Clark" };
        string[] Clan = { "BANU HAQIM", "BRUJAH", "GANGREL", "HECATA", "LASOMBRA", "MALKAVIAN", "SETITI", "NOSFERATU", "RAVNOS", "SALUBRI", "TOREADOR", "TREMERE", "TZIMISCE", "VENTRUE", "SANGUE DEBOLE", "CAITIFF" };
        string[] Statistiche = { "Forza", "Destrezza", "Costituzione", "Carisma", "Persuasione", "Autocontrollo", "Intelligenza", "Prontezza", "Fermezza" };
        string[] Abilità = { "Armi da fuoco", "Atletica", "Criminalità", "Furtività", "Guidare", "Manualità", "Mischia", "Rissa", "Sopravvivenza", "Affinità Animale", "Autorità", "Bassifondi", "Convincere", "Espressività", "Galateo", "Intimidire", "Intuito", "Sotterfugio", "Accademiche", "Allerta", "Finanza", "Investigare", "Medicina", "Occulto", "Politica", "Scienze", "Tecnologia" };
        string[] Abilità1 = { "Armi da fuoco", "Atletica", "Criminalità", "Furtività", "Guidare", "Manualità", "Mischia", "Rissa", "Sopravvivenza", "Affinità Animale", "Autorità", "Bassifondi", "Convincere", "Espressività", "Galateo", "Intimidire", "Intuito", "Sotterfugio", "Accademiche", "Allerta", "Finanza", "Investigare", "Medicina", "Occulto", "Politica", "Scienze", "Tecnologia" };
        string[] Accademiche = { "Matematica", "Fisica", "Chimica", "Informatica", "Storia", "Filosofia", "Letteratura", "Biologia", "Economia", "Psicologia" };
        string[] LavoriManuali = { "Cucina", "Toelettatura", "Chirurgia", "Macelleria", "Ricamo", "Cucito", "Maglieria", "Pittura", "Scultura", "Ceramica", "Intaglio del legno", "Intaglio del marmo", "Saldatura", "Falegnameria", "Sartoria", "Quilting", "Tessitura", "Lavorazione del cuoio", "Gioielleria", "Lavorazione del vetro", "Mosaico", "Decorazione di oggetti", "Cartapesta", "Origami", "Modellazione in argilla", "Grafica ad acqua", "Taglio della carta", "Lavorazione del metallo", "Realizzazione di maschere", "Lavorazione di perline", "Decorazione di torte", "Ghirlande e decorazioni natalizie", "Costruzione di bambole", "Intreccio di cesti", "Lavori domestici" };
        string[] Espressività = { "Teatro", "Musica", "Danza", "Canto", "Pittura", "Scultura", "Fotografia", "Cinema", "Letteratura", "Poesia", "Commedia", "Cabaret", "Stand-up comedy", "Mimo", "Giocoleria", "Magia", "Circo", "Performance art", "Street art", "Graffiti", "Grafia", "Scherma", "Kata", "nuoto sincronizzato" };
        string[] Scienze = { "Fisica", "Chimica", "Biologia", "Matematica", "Informatica", "Ingegneria", "Medicina", "Geologia", "Astronomia", "Scienze ambientali", "Scienze della terra", "Scienze dei materiali", "Scienze agrarie", "Neuroscienze", "Biotecnologie", "Biochimica", "Farmacologia", "Robotica", "Intelligenza artificiale", "Energia rinnovabile", "Armaiolo", "Demolizioni", "Balistica" };
        string[] ArmiDaFuoco = { "Pistola", "Prototipi", "Fucile a pompa", "Fucile d'assalto", "Fucile a precisione", "Mitragliatrice", "Lanciagranate", "Pistola mitragliatrice", "Fucile a canne mozze", "Fucile a ripetizione", "Armi da caccia", "Arma silenziata", "Tiro di precisione", "Balistica", "Sparo in movimento", "Sparo di copertura", "Sparo multiplo", "Urbano", "Agente di polizia", "Militare", "Agente di sicurezza", "Cecchino", "Guardia del corpo", "Armaiolo", "Direttore di tiro", "Armi storiche", "Rievocatore", "Pistole automatiche", "Fucili da caccia", "Mitragliatrici pesanti", "Fucili a pompa", "Fucili da cecchino", "Armi leggere", "Armi automatiche", "Armi ad aria compressa", "Armi d'assalto", "Armi da tiro a lunga distanza", "Armi da tiro a corta distanza", "Armi pesanti", "Armi silenziose", "Armi a micidiale precisione", "Armi da difesa personale", "Armi da guerra", "Armi da caccia grossa", "Armi da combattimento ravvicinato", "Armi da artiglieria", "Armi da fuoco per la polizia" };
        string[] Atletica = { "Corsa", "Salto in lungo", "Lancio del peso", "Sollevamento pesi", "Arrampicata", "Nuoto", "Ginnastica artistica", "Pallavolo", "Pugilato", "Triathlon", "Resistenza", "Equilibrio", "Corsa ad ostacoli", "Staffetta", "Pentathlon moderno", "Decathlon", "Biathlon", "Pompiere", "Soldato", "Personal trainer", "Addetto alla sicurezza", "Caricatore", "Muratore", "Taglialegna", "Minatore", "Fabbro", "Corsa su pista", "Salto in alto", "Lancio del giavellotto", "Corsa a ostacoli", "Corsa su strada", "Danza", "Yoga", "Pilates", "Tai Chi", "Calisthenics", "Running trail" };
        string[] Criminalità = { "Furto", "Rapina", "Truffa", "Spaccio di droga", "Riciclaggio di denaro", "Estorsioni", "Contrabbando", "Associazione a delinquere", "Hacking", "Crimine organizzato", "Scasso", "Rapina in banca", "Truffe finanziarie", "Spaccio ", "Finanza", "Crimine organizzato", "Detective privato", "Avvocato penalista", "Polizia investigativa", "Criminologo", "Analista delle frodi", "Furto a mano armata", "Traffico di droga", "Furto d'auto", "Riciclaggio di denaro", "Assassinio", "Ricatti", "Contrabbando di armi", "Rapina in banca", "Frode finanziaria", "Riciclaggio di beni rubati", "Traffico di esseri umani", "Estorsione", "Ricettazione", "Contraffazione di documenti", "Cyber-crimine", "Atti di vandalismo", "Truffa online", "Smuggling", "Truffa su larga scala" };
        string[] Furtività = { "Nascondere", "Furto", "Nascondersi nella folla", "Intrusione", "Spionaggio", "Fuga dall'arresto", "Seguire qualcuno senza essere visto", "Sabotaggio", "Sottrarsi alla sorveglianza", "Aggirare allarmi", "Scassinatore", "Ladro", "Agente segreto", "Fuggitivo", "Assassino", "Luoghi ad alto rischio", "Musei", "Complessi militari", "Scenari di guerra", "Complessi Governativi", "Ambiente Rurale", "Ambiente Casalingo", "Guardia del corpo", "Agente investigativo", "Incursore", "Caccia", "Fotografia naturalistica", "Escursionismo", "Camping", "Osservazione della fauna selvatica", "Birdwatching", "Giochi di prestigio", "Origliare", "Scippo", "Guardone", "Microspie", "Droni di sorveglianza", "Messaggi Criptati" };
        string[] Guidare = { "Guidare in pista", "Trasporto merci su strada", "Trasporto pubblico", "Fuga", "Guida sportiva", "Guidare in off-road", "Trasporto su lunghe distanze", "Servizio taxi", "Guida di veicoli militari", "Trasporto di emergenza", "Pilota di auto da corsa", "Autista di camion", "Autista di autobus", "Pilota di veicoli militari", "Città trafficata", "Strade di montagna", "Deserto", "Pista da corsa", "Fuoristrada", "Autista di taxi", "Autotrasportatore", "Autista di autobus", "Autista di pullman turistico", "Autista di ambulanza", "Meccanico", "Ingegnere automobilistico", "Designer di veicoli", "Venditore di auto", "Istruttore di guida", "Restauro di auto d'epoca", "Customizzazione di auto", "Droni", "Simulazioni di guida", "Navigazione", "Mezzi pesanti", "Veicoli in condizioni meteorologiche avverse", "Ambienti urbani congestionati", "Veicoli sportivi in pista", "Veicoli per trasporto di liquidi e gas", "Veicoli militari", "Veicoli agricoli", "Trasporto di animali", "Trasporto di persone", "Trasporto di merci pericolose", "Città storiche con strade strette e tortuose", "Motocili", "Cicli", "Modelli d'epoca", "Veivoli", "Autocarri", "Autotreni" };
        string[] Mischia = { "Autodifesa personale", "Sopravvivenza nella natura", " Armi improvvisate", "Sport da combattimento", "Acrobazie", "Arte del lancio", "Evasione", "Torturare", "Furtività", "Velocità", "Forza", "Precisione", "Agilità", "Larper", "Schermidore", "Rievocazione", "Bodyguard", "Poliziotto", "Soldato", "Vigilante", "Guardia del corpo", "Arti marziali Occidentali", "Spada corta", "Spada lunga", "Katana", "Machete", "Saif", "Falcione", "Gladio", "Spada da lato", "Pugnale", "Mazzafrusto", "Shamshir", "Martello da guerra", "Clava", "Mazza chiodata", "Mazza ferrata", "Mazza da cavalleria", "Maglio", "Randello", "Kata", "Mazza di ferro", "Schiavona", "Bastone", "Catena", "Nunchaku", "Kukri", "Gurkha", "Kris", "spada a due lame", "Kampilan", "Arti marziali orientali", "Armi antiche", "Alabarda", "Armature", "Scudi", "Pugnali", "Spade", "Mazze", "Asce", "Catene", "Garrota", "Armi Improvvisate", "Randelli", "Scherma", "Tafferugli", "Disarmare", "Difesa dagli animali", "Scimitarra", "Morgenstern", "Lama chiodata", "Lancia", "Partigiana" };
        string[] Rissa = { "Difendersi da un aggressore", "Rispondere a un'offesa verbale", "Gestire conflitti", "Pugile", "Lottatore", "Artista marziale", "Bouncer", "Bodyguard", "Strada", "Discoteca", "Rissa da bar", "Stadio", "Palestra", "Guardia del corpo", "Vigilante", "Buttafuori", "Pugile professionista", "Lottatore professionista", "MMA", "Boxe", "Kickboxing", "Muay Thai", "Jiu Jitsu", "Sparring", "Difesa personale", "Karate", "Kung Fu", "Tae Kwon Do", "Aikido", "Judo", "Tai Chi Chuan", "Wing Chun", "Krav Maga", "Capoeira", "Jeet Kune Do", "Boxe", "Kickboxing", "Muay Thai", "Savate", "Sambo", "Wrestling", "Jiu Jitsu brasiliano", "Vale Tudo", "Pugilato", "Sanda", "Tafferugli", "Intimidire", "Estorcere informazioni", "Combattimento a mani nude", "Arti marziali orientali", "Boxe", "Lotta libera", "Wrestling", "Judo", "Karate", "Taekwondo", "Capoeira", "Krav Maga", "Sambo", "Hapkido", "Kung Fu", "Jeet Kune Do", "Muay Thai", "Savate", "Eskrima", "Aikido", "Kickboxing", "Vale Tudo", "Corpo a corpo", "Gambe", "Braccia", "Rissa da bar", "Tafferugli", "Disarmare a mani nude", "Difesa dagli animali" };
        string[] Sopravvivenza = { "Estrema", "Foresta", "Deserto", "Oceano", "Montagna", "Tundra", "Guida turistica", "Istruttore di sopravvivenza", "Scout", "Guardia forestale", "Militare", "Escursionista", "Camping", "Survivalismo", "Bushcraft", "Caccia e pesca", "Trekking", "Crafting", "Urbana", "Clandestinità", "Squatter", "Navigazione in ambienti naturali", "Costruzione di rifugi improvvisati", "Acquisizione e purificazione di acqua", "Raccolta e preparazione di cibo selvatico", "Trappole e cattura di animali", "Utilizzo di strumenti di orientamento", "Gestione del fuoco", "Pronto soccorso in ambienti naturali", "Resistenza alle condizioni climatiche estreme", "Valutazione e utilizzo delle risorse naturali", "Conoscenza di piante medicinali", "Costruzione di armi improvvisate", "Utilizzo di tecniche di camuffamento", "Costruzione di veicoli improvvisati", "Costruzione di strumenti di comunicazione improvvisati", "Preparazione di strumenti di illuminazione", "Navigazione in mare aperto", "Acquisizione e utilizzo di materiali di sopravvivenza", "Strumenti di difesa improvvisati", "Esplorazione urbana", "Esplorazione", "Giungla", "Seguire tracce" };
        string[] AffinitaAnimale = { "Falconeria", "Zoologia applicata", "Addestramento cinofilo", "Addestramento felino", "Ippoterapia", "Cani", "Gatti", "Uccelli", "Roditori", "Felini", "Cani selvatici", "Uccelli rapaci", "Insetti", "Veterinario", "Biologo", "Guardiaparco", "Allevatore", "Istruttore di equitazione", "Addestramento di base", "Agility", "Addestramento per la ricerca e il soccorso", "Addestramento per la caccia", "Spettacolo", "Addestramento al combattimento", "Addestramento animali", "Comunicazione con animali", "Identificazione di tracce di animali", "Identificazione di malattie degli animali", "Identificazione di animali velenosi", "Identificazione di animali pericolosi", "tecniche di avvicinamento agli animali", "Utilizzo di tecniche di caccia", "Identificazione di habitat degli animali", "Allevamento", "comportamenti degli animali", "cicli riproduttivi degli animali", "Identificazione di specie animali", "salvataggio degli animali", "Cura degli animali", "Falconeria", "Cavalli", "Lupi", "Pacificare", "Serpenti", "Topi", "Cani" };
        string[] Autorità = { "Direttiva", "Educativa", "Gestione di gruppi", "Negoziazione", "Amministrazione", "Motivatore", "Manager", "Capo progetto", "Comandante militare", "Direttore d'orchestra", "Manager", "Allenatore", "Insegnante", "Consulente aziendale", "Militare", "Persuasione", "Improvvisazione", "Dialettica", "Argomentazione", "Storytelling", "Coaching", "Politica", "Militare", "Gestione del personale", "Leadership", "Dinamiche di squadra", "dinamiche da brnaco", "Ispirazione", "Oratoria", "Praxis", "Riforme istituzionali", "Comunicazione istituzionale:", "Politica", "Sicurezza:", "Etica", "Responsabilità sociale:", "Diritti umani" };
        string[] Bassifondi = { "Spionaggio", "Furtività", "Sopravvivenza", "Truffa", "Raccolta informazioni", "Protezione ", "Attività politiche", "Contrabbando", "Agente di sicurezza", "Agente di polizia investigativa", "Detective privato", "Reporter di cronaca nera", "Assistente sociale", "Ghetti", "Porto", "Slums", "Borseggiatore", "Spacciatore", "Guardia del corpo", "Prostituta", "Assassino ", "Trafficante di droga", "Falsario", "Ricettatore", "Rapinatore", "Addescatrice", "Rigattiere", "Mescolarsi nella folla", "Corruzione", "Droghe", "Fama", "Gang", "Graffiti", "Mercato nero", "Prostituzione", "Ricettazione", "Sopravvivenza Urbana", "Traffico d'armi", "Traffico di droga", "Riciclaggio di denaro", "Gioco d'azzardo illegale", "Furto d'identità", "Attività criminali organizzate", "Hacking", "Cyber-crimine" };
        string[] Convincere = { "Vendere", "Negoziazione", " Obiezioni", "Report", "Gestione del conflitto", "Presentazione ", "Storytelling", "Venditore", "Avvocato", "Politico", "Agente immobiliare", "Manager", "Presenter in pubblico", "Leader di team", "Insegnante", "Attivista politico", "Speaker", "Improvisazione teatrale", "Spettacoli", "Podcasting", "Storytelling", "Scrittura creativa" };
        string[] Galateo = { "Comportamento a tavola", "Etichetta negli incontri", "Comportamento in pubblico", "Protocollo di cerimonie ufficiali", "Modalità di scrittura", "Presentazioni formali", "Cerimonie religiose", "Incontri diplomatici", "Eventi di gala", "Interviste di lavoro", "Funzionario pubblico", "Diplomatico", "Consulente di immagine", "Organizzatore di eventi", "Esperto di moda", "Matrimonio", "Cena di gala", "Funerale", "Incontro di lavoro", "Galateo moderno", "Galateo internazionale", "Religioso", "Incontro galante", "Seduzione", "Militare", "Galateo militare", "Galateo aziendale", "Galateo diplomatico", "Galateo religioso", "Galateo a tavola", "Galateo in famiglia", "Galateo in pubblico", "Comunicazioni online", "Nel mondo artistico", "Ospitalità", "Matrimoni", "Funerali", "Teatro", "Nell'educazione", "Nel mondo del lavoro", "Cerimoniale", "Medievale", "Camarilla", "Anarchici", "Sabbath", "Società Segreta", "Elysium" };
        string[] Intimidire = { "Minacce fisiche", "Toni di voce aggressivi", "Sguardo fisso", "Gesti violenti", "Postura fisica imponente", "Negoziazioni ", "Contrattazioni", "Interrogatori", "Conflitti coniugali", "Scontro tra bande rivali", "Intimidazione fisica", "Intimidazione verbale", "Intimidazione psicologica", "Intimidazione sessuale", "Intimidazione finanziaria", "Avvocato difensore", "Interrogatore", " criminale", "Manager ", "Comandante militare", "Coach sportivo", "Guardia del corpo", "Insegnante disciplinare", "Arbitro sportivo", "Buttafuori", "Sindacalista", "Fisica", "Verbale", "Psicologica", "A scopo di lucro", "Politica", "A sfondo razziale", "A sfondo sessuale", "Intimidazione criminale", "In ambito lavorativo", "In ambito sportivo", "In ambiente scolastico", "In ambiente domestico", "A sfondo religioso", "In ambito militare", "Insulti", "Confronto di sguardi", "Minacce velate" };
        string[] Intuito = { " cambiamenti improvvisi nell'ambiente circostante", "Ispirazioni e idee improvvise", "Capacità di leggere l'atmosfera emotiva di una situazione", "Riconoscere le intenzioni delle persone", "Individuare la verità tra le bugie", "Negoziati", "Investigazioni", "Individuazione", "Intuizione ambientale", "Intuizione creativa", "Intuizione emotiva", "Intuizione sociale", "Intuizione logica", "Investigatore privato", "Psicologo", "Politico", "Gestore di risorse umane", "Terapista", "Coach di vita", "Arbitro sportivo", "Diplomatico", "Counselor", "Relazioni pubbliche", "Ambizioni", "Emozioni", "Desideri", "Fobie", "Empatia", "Interrogare", "Linguaggio corporeo", "Bugie", "Vizi" };
        string[] Sotterfugio = { "Mascherarsi", "Insabbiare", "Raggirare", "Infiltrarsi", "Eludere", "Falsificare", "Creare diversivi", "Ladro", "Agente segreto", "Assassino", "Spionaggio", "Giocatore d'azzardo", "Falsario", "Nascondere ", "Truffatore", "Convincere", "Sedurre", "Bluff", "Bugie", "Fingere", "Innocenza", "Colpevolezza", "Raggiro", "Seduzione", "Raggiro per lungo tempo", "Travestirsi", "Impersonare identità" };
        string[] Allerta = { "Mantenere la concentrazione", "Rapidità decisionale", "Intravedere pericoli", "Evitare trappole", "Prevenire incidenti", "Individuare comportamenti sospetti", "Vigile del fuoco", "Soldato", "Pilota", "Guardia giurata", "Poliziotto", "Soccorritore", "Addetto alla sicurezza", "Marinaio", "Sport estremi", "Parkour", "Arti marziali", "Caccia", "Guidare", "Sciare", " Chirurgia", "Diving", "Ambienti naturali", "Imboscate", "Olfatto", "Oggetti nascosti", "Vista", "Trappole", "Udito", "Tattica", "Anticipatoria", "Visiva" };
        string[] Finanza = { "Analisi di bilancio", "Contabilità", "Commercialista", "Consulente", "Analista", "Numismatica", "Ricerca di oggetti d'antiquariato", "Scambio di valute estere", "Scommesse", "Investimenti", "Gestione del budget", "Pianificazione finanziaria", "Analisi di un'aziendali", "Borsa", "Banche", "Istituti di credito", "Mercati finanziari", "Fondi di investimento", "Assicurazioni", "Mercato Nero", "Belle arti", "Analisi di bilancio", "Gestione del rischio finanziario", "Analisi di mercato", "Gestione degli investimenti", "Investimenti", "Prestiti", "Gestione del flusso di cassa", "Pianificazione finanziaria", "Analisi finanziaria" };
        string[] Investigare = { "Forense", "Storico", "Epidemiologico", "Analista", "Ricostruzione di eventi", "Avvocato penalista", "Criminologo", "Agente investigativo ", "Investigatore privato", "Agente di polizia", "Analista di intelligence", " informatico", "Penali", "Civili", "Amministrative", "Finanziarie", "Informatiche", "Giornalista", "Scene del crimine", "Studi legali", "Agenzie investigative", "Laboratori scientifici per l'analisi delle prove", "Banche dati delle forze dell'ordine", "Analisi delle prove fisiche", "Interviste e interrogatori", "Ricerca e analisi di informazioni online", "Analisi del comportamento criminale", "Tracciamento di individui o oggetti", "Omicidi", "Medicina legale", "Analisi del traffico", "Criminologia", "Misteri paranormali", "Persone scomparse" };
        string[] Medicina = { "Cardiologia", "Oncologia", "Neurologia", "Pediatria", "Chirurgia", "Trapianto ", "Radioterapia", "TAC", "Laparoscopia", "Endoscopia", "Diagnosi ", "Cura di malattie", "Prevenzione di malattie", "Medico", "Infermiere", "Farmacista", "Tecnico di radiologia", "Fisioterapista", "Ricercatore ", "Docente ", "Scienze infermieristiche", "Ostetricia", "Biotecnologie mediche", "Fisioterapia", "Chirurgia generale", "Medicina interna", "Psichiatria", "Anestesia e rianimazione", "Anamopatologia", "Patologie", "Veterinaria", "Ematologia", "Cardiologia", "Oftalmologia", "Ortopedia" };
        string[] Occulto = { "Necromanzia", "Mitologia", "Divinazione", "Alchimia", "Demonologia", "Evocazione", "Sigillazione di demoni", "Creare pozioni", "Sciamanesimo", "Protezione", "Predizione", "Esorcista", "Indagatore dell'occulto", "Cacciatore di creature sovrannaturali", "Investigatore del paranormale", "Teurgia", "Magia nera", "Magia bianca", "Chaos magic", "Magia elementale", "Crimini occulti", "Sette", "Esoterismo", "Stregoneria", "Astrologia", "Tarocchi", "Numerologia", "Cabala", "Sigillazione", "Esorcismo", "Necromanzia", "Occultismo Egizio", "Occultismo Celtica", "Occultismo Greco", "Occultismo Romano", "Occultismo Nordico", "Liber AL vel Legis", "Il Grimorio di San Cipriano", "Il Grande Grimorio", "La Chiave di Salomone", "Fate", "Licantropi", "Vampiri", "Magia del sangue", "Maghi", "Vudù", "Infernalismo", "Wicca", "Magia ermetica", "Elementale", "Naturale" };
        string[] Politica = { "Politica internazionale", "Diritto politico", "Comunicazione", "Gestione del potere", "Lobbying", "Negoziazione", "Elaborazione di politiche ", "Risoluzione di conflitti politici", "Politico", "Funzionario pubblico", "Diplomatico", "Consulente politico", "Analista politico", "Esperto di relazioni internazionali", "Campagne elettorali", "Riforme costituzionali", "Accordi commerciali", "Pianificazione urbana", "Programmi di welfare", "Anarchici", "Camarilla", "Clan(specifico)", "Diplomazia", "Governo cittadino", "Media", "Politica nazionale", "Politica estera", "Elezioni locali", "Amministrazione pubblica", "Partiti politici", "Attivismo sociale", "Lobbismo", "Diritto costituzionale", "Organizzazioni internazionali", "Comunicazione politica", "Strategie di campagna elettorale", "Negoziazione politica", "Analisi dei dati politici", "Gestione del budget pubblico", "Analisi delle politiche pubbliche", "Comunicazione politica digitale", "Analisi delle relazioni internazionali", "Giustizia costituzionale", "Costruire e gestire alleanze politiche", "Elaborare politiche pubbliche", "Fornire consulenza politica ai candidati", "Valutare le politiche pubbliche esistenti", "Monitorare le elezioni e le decisioni politiche" };
        string[] Tecnologia = { "Ingegneria", "Robotica", "Intelligenza artificiale", "Cybersecurity", "Automazione", "Analisi dei dati", "Creazione di sistemi di intelligenza artificiale", " Produzione di dispositivi elettronici", "Sviluppo software", "Ingegnere meccanico", "Tecnico informatico", "Scienziato dei dati", "Scurezza informatica", "Technology Officer", "Responsabile IT", "Architetto software", "Analista di sistemi", "Project manager", "Fai da te", "Gaming", "Elettronica", "3D printing", "Tecnologie dell'informazione", "Elettronica di consumo", "Automazione industriale", "Biotecnologie", "Meccanica", "Nanotecnologie", "Progettazione di dispositivi elettronici", "Programmazione", "Sistemi di sicurezza informatica", "Networking", "Intelligenza Artificiale", "Hardware", "Robotica", "Elettronica", "Telecomunicazioni", "Realizzazione di software", "Ingegneria informatica", "Programmazione", "Penetration Testing", "Progettazione di reti aziendali", "Sviluppo di algoritmi di Intelligenza Artificiale", "Progettazione di circuiti integrati", "Costruzione di robot umanoidi", "Sviluppo di nuovi dispositivi per la videosorveglianza", "Sviluppo di software per la realtà virtuale", "Progettazione di antenne satellitari", "Realizzazione di software per la simulazione di fenomeni fisici", "Creazione di un software per la gestione del magazzino", "Installazione e configurazione di un sistema di sicurezza informatica aziendale", "Progettazione di i WiFi ", "Creazione di un algoritmi", "Sviluppo di un hardware", "Costruzione di robot", "Controllo del traffico urbano basato sull'IoT." };
        string[] Predatore = { "Accattone", "Allevatore", "Consensualista", "Osiride", "Randagio", "Regina della scena", "Sandman", "Sanguisuga", "Simulante", "Sirena" };
        int[] Mesi = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        int[] PrimeDuecifre = { 1000, 1100, 1200, 1300, 1400, 1500, 1600, 1700, 1800, 1900, 2000 };
        int[] SecondeDuecifre = { 00,01, 02, 03, 04, 05, 06, 07, 08, 09, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99 };
        int Salute = 0;
        int Volontà;
        int Fermezza = 0;
        int _ChosenAbility;
        int Autocontrollo = 0;
        public int num_difettipoints = 2;
        public int num_vantaggipoints = 7;
        string SpecialPredatore = " ";
        string PowerPredatore = " ";
        public string DifettoPredatore = " ";
        public string PregioPredatore = " ";
        string dataNascita;
        int borngiorno;
        int bornmese;
        int NumFama = 0;
        int NumGregge = 0;
        int NumNemici = 0;
        int NumMitici = 0;
        int NumCrimine = 3;
        int i = 0;
        public int NumUmanità = 0;
        public int BloodPotency = 0;
        public int generation;
        public string clanname;
        public string pgname;
        public string sirename;
        public string Predator;
        public int bonusxp;
        public int vampireage;
        public string vampiretitle;
        public string[] poteri = {"","","","","", "", "", "", "", "", "", "", "", "", "" };
        public int indexAA = 0;
        Random rand = new Random();
        Random random = new Random();
        Random Rand = new Random();
        Random RandomAbility = new Random();
        Random AbilityValue = new Random();
        Random RandomPowerValue = new Random();
        Random SangueDebolePower = new Random();
        Random FameRandom = new Random();
        Random UmanitàRandom = new Random();
        Random NomeRandom = new Random();
        Random CognomeRandom = new Random();
        Random NomeRandomSire = new Random();
        Random CognomeRandomSire = new Random();
        Random RandomSpecialitaAccademica = new Random();
        Random RandomSpecialitaLavoriManuali = new Random();
        Random RandomSpecialitaPerformance = new Random();
        Random RandomSpecialitaScienze = new Random();
        Random AbilitàSpecialitàRandom = new Random();
        Random Spec = new Random();
        Random Centinaia = new Random();
        Random Decine = new Random();
        Random Mese = new Random();
        Random Giorno = new Random();
        Random RandomPredatore = new Random();
        int CurrentYear = DateTime.Now.Year;

        public string Main( bool ageAbilitated)
        {
            int NomePg = NomeRandom.Next(Nome.Length);
            int CognomePg = CognomeRandom.Next(Cognome.Length);
            int NomeSireRandom = NomeRandomSire.Next(Nome.Length);
            int CognomeSireRandom = CognomeRandomSire.Next(Cognome.Length);
            int Razza = random.Next(Clan.Length);
            int PredatorType = RandomPredatore.Next(Predatore.Length);
            int rdecine = Decine.Next(SecondeDuecifre.Length);
            int rcentinaia = Centinaia.Next(PrimeDuecifre.Length);
            int rmese = Mese.Next(Mesi.Length);
            int centinaia = PrimeDuecifre[rcentinaia];
            int decine = SecondeDuecifre[rdecine];
            int mese = Mesi[rmese];
            int giorno;
            int Anno = centinaia + decine;
            bool[] isTaken = new bool[Abilità.Length];
            int ChosenAbility;

            if (Anno> CurrentYear)
            { while (Anno > CurrentYear)
                 centinaia = PrimeDuecifre[rcentinaia];
                 decine = SecondeDuecifre[rdecine];
                 rdecine = Decine.Next(SecondeDuecifre.Length);
                 rcentinaia = Centinaia.Next(PrimeDuecifre.Length);
                Anno = centinaia + decine;
            }
            if (mese == 02) { giorno = Giorno.Next(0, 29);}
            else if (mese == 01 || mese == 03 || mese == 05 || mese == 06 || mese == 07 || mese == 10 || mese == 12) { giorno = Giorno.Next(0, 31);}
            else
            {
                 giorno = Giorno.Next(0, 30);

            }
            int bornanno=0;
            rdecine = Decine.Next(SecondeDuecifre.Length);
            rcentinaia = Centinaia.Next(PrimeDuecifre.Length);
            centinaia = PrimeDuecifre[rcentinaia];
            decine = SecondeDuecifre[rdecine];
            bornanno = centinaia + decine;
            var _age = Anno - bornanno;
            if (ageAbilitated == true)
            {
                while (_age < 1)
                {
                    int _rcentinaia = Anno / 100;
                    int _Rcentina = _rcentinaia * 100;
                    int _rdecine = Anno - _Rcentina;
                    int rightcentindex = Array.IndexOf(PrimeDuecifre, _Rcentina);
                    int rightrdecindex = Array.IndexOf(SecondeDuecifre, _rdecine);
                    rdecine = Decine.Next(rightrdecindex);
                    rcentinaia = Centinaia.Next(rightcentindex);
                    centinaia = PrimeDuecifre[rcentinaia];
                    decine = SecondeDuecifre[rdecine];
                    bornanno = centinaia + decine;
                    _age = Anno - bornanno;
                    continue;
                }
            }
            else
            {
                while (_age <18)
                {
                    int _rcentinaia = Anno / 100;
                    int _Rcentina = _rcentinaia * 100;
                    int _rdecine = Anno - _Rcentina;
                    int rightcentindex = Array.IndexOf(PrimeDuecifre, _Rcentina);
                    int rightrdecindex = Array.IndexOf(SecondeDuecifre, _rdecine);
                    rdecine = Decine.Next(rightrdecindex);
                    rcentinaia = Centinaia.Next(rightcentindex);
                    centinaia = PrimeDuecifre[rcentinaia];
                    decine = SecondeDuecifre[rdecine];
                    bornanno = centinaia + decine;
                    _age = Anno - bornanno;
                    continue;
                }
            }
            Mese.Next(Mesi.Length);
             bornmese = Mesi[rmese];
            if (bornmese == 02) {  borngiorno = Giorno.Next(0, 29);  dataNascita = "Nato il: " + giorno + "," + mese + "," + bornanno; }
            else if (bornmese == 01 || bornmese == 03 || bornmese == 05 || bornmese == 06 || bornmese == 07 || bornmese == 10 || bornmese == 12) {  borngiorno = Giorno.Next(0, 31);  dataNascita = "Nato il: " + borngiorno + "," +bornmese  + "," +bornanno; }
            else
            {   
                 borngiorno = Giorno.Next(0, 30);
                dataNascita = "Nato il: " + borngiorno + "," + bornmese + "," + bornanno;
            }

             vampireage = CurrentYear-Anno;
            if ( vampireage <= 0 || vampireage > 250)
            {
                while (Anno >= CurrentYear || CurrentYear - Anno > 250 )
                {  
                        int _rcentinaia = CurrentYear / 100;
                        int _Rcentina = _rcentinaia * 100;
                        int _rdecine = CurrentYear - _Rcentina;
                        int rightcentindex = Array.IndexOf(PrimeDuecifre, _Rcentina);
                        int rightrdecindex = Array.IndexOf(SecondeDuecifre, _rdecine);
                        rdecine = Decine.Next(rightrdecindex);
                        rcentinaia = Centinaia.Next(rightcentindex);
                        centinaia = PrimeDuecifre[rcentinaia];
                        decine = SecondeDuecifre[rdecine];
                        Anno = centinaia + decine;
                        vampireage = CurrentYear - Anno; 
                }
            }

             if (vampireage>83 && vampireage < 250)
            {
                 vampiretitle = "Ancillae";
                BloodPotency = 2;
                bonusxp = 35;
                NumUmanità = -1;
                num_difettipoints  = num_difettipoints + 2;
                num_vantaggipoints = num_vantaggipoints + 2;
                
                Random rgeneration = new Random();
                int _generation = rgeneration.Next(1, 3);
                if (_generation == 1)
                {
                    generation = 10;
                }
                else
                {
                    generation = 11;
                }
            }
            else if (vampireage <= 83 && vampireage>15)
            {
                 vampiretitle = "Neonato";
                 bonusxp = 15;
                BloodPotency = 1;
                Random rgeneration = new Random();
                int _generation = rgeneration.Next(1, 3);
                if (_generation == 1)
                {
                    generation = 12;
                }
                else
                {
                    generation = 13;
                }

            }
            else if ( vampireage < 15 && vampireage >=0)
            {
                 vampiretitle = "Infante";
                Random rgeneration = new Random();
                int _generation = rgeneration.Next(1, 3);
                if (_generation == 1)
                {
                    Random _rgeneration = new Random();
                    generation = _rgeneration.Next(14, 17);
                    BloodPotency = 0;
                }
                else
                {
                    Random _rgeneration = new Random();
                    generation = _rgeneration.Next(12, 14);
                    BloodPotency = 1;
                }
            }

            string dataAbbraccio = "Abbarracciato il: " + giorno + "," + mese + "," + Anno;


            Predator = Predatore[PredatorType];


            if (Predator == "Accattone")
            {
                Random RandomSpecialPredatore = new Random();
                int randomSpecialPredatore = RandomSpecialPredatore.Next(0, 5);
                if (randomSpecialPredatore == 0) { SpecialPredatore = "Bassifondi: Mercato nero"; }
                else if (randomSpecialPredatore == 1) { SpecialPredatore = "Criminalità: Scassinare serrature"; }
                else if (randomSpecialPredatore == 2) { SpecialPredatore = "Bassifondi: Mercato nero"; }
                else if (randomSpecialPredatore == 3) { SpecialPredatore = "Criminalità: Scassinare serrature"; }
                Random RandomPowerPredatore = new Random();
                int randomPowerPredatore = RandomPowerPredatore.Next(0, 5);
                if (randomPowerPredatore == 0) { SpecialPredatore = "Oscurazione 1"; }
                else if (randomPowerPredatore == 1) { PowerPredatore = "Stregoneria del sangue 1"; }
                else if (randomPowerPredatore == 2) { PowerPredatore = "Oscurazione 1"; }
                else if (randomPowerPredatore == 3) { PowerPredatore = "Stregoneria del sangue 1"; }
                PregioPredatore = "Stomaco di ferro 3";
                DifettoPredatore = "Nemico";
            };

            if (Predator == "Allevatore")
            {
                if (BloodPotency > 3) { RandomPredatore.Next(Predatore.Length); }
                else
                {
                    Random RandomSpecialPredatore = new Random();
                    int randomSpecialPredatore = RandomSpecialPredatore.Next(0, 5);
                    Random Animale = new Random();
                    string[] animali = { "Cane", "Gatto", "Elefante", "Leone", "Tigre", "Orso", "Ippopotamo", "Rinoceronte", "Giraffa", "Scimmia", "Zebra", "Panda", "Koala", "Canguro", "Pecora", "Muflone", "Cavallo", "Maiale", "Mucca", "Gallina" };
                    int ChoosenAnimal = Animale.Next(animali.Length);
                    string choosenanimal = animali[ChoosenAnimal];
                    if (randomSpecialPredatore == 0) { SpecialPredatore = "Affinità animale: " + choosenanimal; }
                    else if (randomSpecialPredatore == 1) { SpecialPredatore = "Sopravvivenza: Caccia"; }
                    else if (randomSpecialPredatore == 2) { SpecialPredatore = "Affinità animale: " + choosenanimal; }
                    else if (randomSpecialPredatore == 3) { SpecialPredatore = "Sopravvivenza: Caccia"; }
                    Random RandomPowerPredatore = new Random();
                    int randomPowerPredatore = RandomPowerPredatore.Next(0, 5);
                    if (randomPowerPredatore == 0) { SpecialPredatore = "Animalità 1"; }
                    else if (randomPowerPredatore == 1) { PowerPredatore = "Proteide 1"; }
                    else if (randomPowerPredatore == 2) { PowerPredatore = "Animalità 1"; }
                    else if (randomPowerPredatore == 3) { PowerPredatore = "Proteide 1"; }
                    //PregioPredatore = "Umanità + 1";
                    NumUmanità = NumUmanità + 1;
                    DifettoPredatore = "Vegano";
                }
            };

            if (Predator == "Consensualista")
            {
                Random RandomSpecialPredatore = new Random();
                int randomSpecialPredatore = RandomSpecialPredatore.Next(0, 5);
                if (randomSpecialPredatore == 0) { SpecialPredatore = "Convincere: Vittime"; }
                else if (randomSpecialPredatore == 1) { SpecialPredatore = "Medicina: Flebotomia"; }
                else if (randomSpecialPredatore == 2) { SpecialPredatore = "Convincere: Vittime"; }
                else if (randomSpecialPredatore == 3) { SpecialPredatore = "Medicina: Flebotomia"; }
                Random RandomPowerPredatore = new Random();
                int randomPowerPredatore = RandomPowerPredatore.Next(0, 5);
                if (randomPowerPredatore == 0) { SpecialPredatore = "Auspex 1"; }
                else if (randomPowerPredatore == 1) { PowerPredatore = "Robustezza 1"; }
                else if (randomPowerPredatore == 2) { PowerPredatore = "Auspex 1"; }
                else if (randomPowerPredatore == 3) { PowerPredatore = "Robustezza 1"; }
                //PregioPredatore = "Umanità + 1";
                NumUmanità = NumUmanità + 1;
                DifettoPredatore = "Segreto oscuro 1 Trasgressore della masquerade-Esclusionne di preda: Non consenzienti";
            };

            if (Predator == "Osiride")
            {
                Random RandomSpecialPredatore = new Random();
                int randomSpecialPredatore = RandomSpecialPredatore.Next(0, 5);
                Random Intrattenimenti = new Random();
                string[] intrattenimenti = new string[] { "Film", "Serie TV", "Musica", "Podcast", "Libri", "Fumetti", "Giochi da tavolo", "Videogiochi", "Sport", "Escursionismo", "Cucina", "Viaggi", "Arte", "Teatro", "Danza", "Yoga", "Pilates", "Meditazione", "Fotografia", "Giardinaggio", "LARP", "GDR", "Cosplay" };
                int ChoosenIntrattenimenti = Intrattenimenti.Next(intrattenimenti.Length);
                string choosenintrattenimenti = intrattenimenti[ChoosenIntrattenimenti];
                Random Tradizioni = new Random();
                string[] tradizioniMagiche = { "Piromanzia", "Idromanzia", "Geomanzia", "Areomanzia", "Ombromanzia", "Magia druidica", "Magia Runica", "Spiritismo", "Stregoneria", "Alchimia", "Profetiche", "Necromanzia", "Magia del Tempo", "Magia del Sangue", "Wicca", "Hoodoo", "Voodoo", "Magia popolare", "Santeria", "Candomblé", "Haitian Vodou", "Brujería", "Stregoneria italiana", "Magia celtica", "Magia egizia", "Magia greca", "Magia romana", "Chaos Magic", "Magia shamanica", "Magia taoista", "Magia induista", "Magia buddhista", "Magia giapponese", "Magia africana", "Magia dei nativi americani" };
                int ChoosenTradizioni = Tradizioni.Next(tradizioniMagiche.Length);
                string choosenintradizioni = tradizioniMagiche[ChoosenTradizioni];
                if (randomSpecialPredatore == 0) { SpecialPredatore = "Espressività: " + choosenintrattenimenti; }
                else if (randomSpecialPredatore == 1) { SpecialPredatore = "Occultismo:" + choosenintradizioni; }
                else if (randomSpecialPredatore == 2) { SpecialPredatore = "Espressività: " + choosenintrattenimenti; }
                else if (randomSpecialPredatore == 3) { SpecialPredatore = "Occultismo:" + choosenintradizioni; }
                Random RandomPowerPredatore = new Random();
                int randomPowerPredatore = RandomPowerPredatore.Next(0, 5);
                if (randomPowerPredatore == 0) { SpecialPredatore = "Ascendente 1"; }
                else if (randomPowerPredatore == 1) { PowerPredatore = "Magia del sangue 1"; }
                else if (randomPowerPredatore == 2) { PowerPredatore = "Ascendente 1"; }
                else if (randomPowerPredatore == 3) { PowerPredatore = "Magia del sangue 1"; }
                Random FamaGregge = new Random();
                int famagregge = FamaGregge.Next(1, 5);
                if (famagregge == 1 || famagregge == 2)
                {
                    Random Fama = new Random();
                    int fama = Fama.Next(1, 4);
                    if (fama == 1)
                    {
                        NumFama = 1;
                        NumGregge = 2;
                    }
                    if (fama == 2)
                    {
                        NumFama = 2;
                        NumGregge = 1;
                    }
                    if (fama == 3)
                    {
                        NumFama = 3;
                        NumGregge = 0;
                    }
                }
                if (famagregge == 2 || famagregge == 3)
                {
                    Random Gregge = new Random();
                    int gregge = Gregge.Next(1, 4);
                    if (gregge == 1)
                    {
                        NumFama = 2;
                        NumGregge = 1;
                    }
                    if (gregge == 2)
                    {
                        NumFama = 1;
                        NumGregge = 2;
                    }
                    if (gregge == 3)
                    {
                        NumFama = 0;
                        NumGregge = 3;
                    }
                };
                Random NemiciMitici = new Random();
                int nemicimitici = FamaGregge.Next(1, 5);
                if (nemicimitici == 1 || nemicimitici == 2)
                {
                    Random Nemici = new Random();
                    int nemici = Nemici.Next(1, 4);
                    if (nemici == 1)
                    {
                        NumNemici = 1;
                        NumMitici = 2;
                    }
                    if (nemici == 2)
                    {
                        NumNemici = 2;
                        NumMitici = 1;
                    }
                    if (nemici == 3)
                    {
                        NumNemici = 3;
                        NumMitici = 0;
                    }
                }
                if (famagregge == 2 || famagregge == 3)
                {
                    Random Mitici = new Random();
                    int mitici = Mitici.Next(1, 4);
                    if (mitici == 1)
                    {
                        NumNemici = 1;
                        NumMitici = 2;
                    }
                    if (mitici == 2)
                    {
                        NumNemici = 2;
                        NumMitici = 1;
                    }
                    if (mitici == 3)
                    {
                        NumNemici = 3;
                        NumMitici = 0;
                    }
                }
                PregioPredatore = "Fama" + NumFama + "-Gregge " + NumGregge;
                DifettoPredatore = "Nemici " + NumNemici + "-Mitici " + NumMitici;
            };

            if (Predator == "Randagio")
            {
                Random RandomSpecialPredatore = new Random();
                int randomSpecialPredatore = RandomSpecialPredatore.Next(0, 5);
                if (randomSpecialPredatore == 0) { SpecialPredatore = "Intimidire: Rapina"; }
                else if (randomSpecialPredatore == 1) { SpecialPredatore = "Rissa: Lotta"; }
                else if (randomSpecialPredatore == 2) { SpecialPredatore = "Intimidire: Rapina"; }
                else if (randomSpecialPredatore == 3) { SpecialPredatore = "Rissa: Lotta"; }
                Random RandomPowerPredatore = new Random();
                int randomPowerPredatore = RandomPowerPredatore.Next(0, 5);
                if (randomPowerPredatore == 0) { SpecialPredatore = "Potenza 1"; }
                else if (randomPowerPredatore == 1) { PowerPredatore = "Velocità 1"; }
                else if (randomPowerPredatore == 2) { PowerPredatore = "Potenza 1"; }
                else if (randomPowerPredatore == 3) { PowerPredatore = "Velocità 1"; }
                NumCrimine = 3;
                PregioPredatore = "Contatti Criminie " + NumCrimine;
                NumUmanità = NumUmanità - 1;
               // DifettoPredatore = "Umanità -1";
            };

            if (Predator == "Regina della scena")
            {
                Random RandomSpecialPredatore = new Random();
                int randomSpecialPredatore = RandomSpecialPredatore.Next(0, 3);
                if (randomSpecialPredatore == 0)
                {
                    Random RandomScenaAutorità = new Random();
                    string[] ListScenaAutorità = { "Uffici governativi", "Tribunali", "Aeroportuale", "Portuale", "Carceraria", "Militare", "Polizia", "Finanza", "Associazioni", "Giornalismo" };
                    int ChooseScenaAutorità = RandomScenaAutorità.Next(ListScenaAutorità.Length);
                    SpecialPredatore = "Autorità: " + ListScenaAutorità[ChooseScenaAutorità];
                }
                else if (randomSpecialPredatore == 1)
                {
                    Random RandomScenaBassifondi = new Random();
                    string[] ListScenaBassifondi = { "Favelas", "Ghetti", "Zone industriali degradate", "Terreni abbandonati", "Periferie degradate", "Zone portuali ", "Zone di spaccio", "Case occupate", "Stazioni" };
                    int ChooseScenaBassifondi = RandomScenaBassifondi.Next(ListScenaBassifondi.Length);
                    SpecialPredatore = "Bassifondi: " + ListScenaBassifondi[ChooseScenaBassifondi];
                }
                else if (randomSpecialPredatore == 2)
                {
                    Random RandomScenaGalateo = new Random();
                    string[] ListScenaGalateo = { "Galateo religioso", "Galateo militare", "Galateo civile", "Galateo lavorativo", "Galateo sociale", "Galateo familiare", "Galateo a tavola", "Galateo formale", "Galateo della camarilla", "Galateo anarchico" };
                    int ChooseScenaGalateo = RandomScenaGalateo.Next(ListScenaGalateo.Length);
                    SpecialPredatore = "Bassifondi: " + ListScenaGalateo[ChooseScenaGalateo];
                }
                Random RandomPowerPredatore = new Random();
                int randomPowerPredatore = RandomPowerPredatore.Next(0, 5);
                if (randomPowerPredatore == 0) { SpecialPredatore = "Dominazione 1"; }
                else if (randomPowerPredatore == 1) { PowerPredatore = "Potenza 1"; }
                else if (randomPowerPredatore == 2) { PowerPredatore = "Dominazione 1"; }
                else if (randomPowerPredatore == 3) { PowerPredatore = "Potenza 1"; }
                Random SubCulture = new Random();
                string[] ListSottocultura = { "Riot grrrl", "Furry fandom", "Cosplay", "LARPing", "Street art", "Graffiti", "Urban exploration", "Zine-making", "Skateboarding", "BMX", "Parkour", "Surfing", "Snowboarding", "Veganism", "Minimalism", "Eco-friendly living", "DIY culture", "Queer culture", "Spiritualism", "Steampunk", "Cyberpunk", "Goth", "Emo", "Punk", "Grunge", "Industrial", "Post-punk", "Darkwave", "Noise", "Free jazz", "Avant-garde", "Experimental", "No wave", "Industrial", "Chiptune", "Lo-fi", "Shoegaze", "Post-rock", "Skate punk", "Ska", "Reggae", "Hip hop", "Metalcore", "Hardcore", "Nu-metal", "Pop punk", "Alternative rock", "Indie rock", "Avvocati", "Militari", "Polizia", "Scienziati", "Criminali", };
                int ChoosenSubCulture = SubCulture.Next(ListSottocultura.Length);
                string choosenSubCulture = ListSottocultura[ChoosenSubCulture];
                PregioPredatore = "Fama 1 - Contatti 1 _ " + choosenSubCulture;
                Random ChooseDifetto = new Random();
                int DifettoScelto = ChooseDifetto.Next(0, 5);
                if (DifettoScelto == 0 || DifettoScelto == 1)
                {
                    DifettoPredatore = "Malvisto al di fuori della sottoculutra " + choosenSubCulture;
                }
                else
                {
                    DifettoPredatore = "Esclusione di preda, si può nutrire solo di chi fa parte/segue la sottocultura" + choosenSubCulture;
                }
            };

            if (Predator == "Sandman")
            {
                Random RandomSpecialPredatore = new Random();
                int randomSpecialPredatore = RandomSpecialPredatore.Next(0, 5);
                if (randomSpecialPredatore == 0) { SpecialPredatore = "Furtività: Effrazione"; }
                else if (randomSpecialPredatore == 1) { SpecialPredatore = "Medicina: Annestesia"; }
                else if (randomSpecialPredatore == 2) { SpecialPredatore = "Furtività: Effrazione"; }
                else if (randomSpecialPredatore == 3) { SpecialPredatore = "Medicina: Annestesia"; }
                Random RandomPowerPredatore = new Random();
                int randomPowerPredatore = RandomPowerPredatore.Next(0, 5);
                if (randomPowerPredatore == 0) { SpecialPredatore = "Oscurazione 1"; }
                else if (randomPowerPredatore == 1) { PowerPredatore = "Auspex 1"; }
                else if (randomPowerPredatore == 2) { PowerPredatore = "Oscurazione 1"; }
                else if (randomPowerPredatore == 3) { PowerPredatore = "Auspex 1"; }
                PregioPredatore = "Risorse 1";
                DifettoPredatore = "N.A";
            }

            if (Predator == "Sanguisuga")
            {
                Random RandomSpecialPredatore = new Random();
                int randomSpecialPredatore = RandomSpecialPredatore.Next(0, 5);
                if (randomSpecialPredatore == 0) { SpecialPredatore = "Furtività: contro Vampiri"; }
                else if (randomSpecialPredatore == 1) { SpecialPredatore = "Rissa: contro Vampiri"; }
                else if (randomSpecialPredatore == 2) { SpecialPredatore = "Furtività: contro Vampiri"; }
                else if (randomSpecialPredatore == 3) { SpecialPredatore = "Rissa: contro Vampiri"; }
                Random RandomPowerPredatore = new Random();
                int randomPowerPredatore = RandomPowerPredatore.Next(0, 5);
                if (randomPowerPredatore == 0) { SpecialPredatore = "Proteide 1"; }
                else if (randomPowerPredatore == 1) { PowerPredatore = "Velocità 1"; }
                else if (randomPowerPredatore == 2) { PowerPredatore = "Proteide 1"; }
                else if (randomPowerPredatore == 3) { PowerPredatore = "Velocità 1"; }
                PregioPredatore = "Potenza del sangue + 1 ";
                BloodPotency = BloodPotency + 1;
                Random ChooseDifetto = new Random();
                int DifettoScelto = ChooseDifetto.Next(0, 5);
                if (DifettoScelto == 0 || DifettoScelto == 1)
                {
                    DifettoPredatore = "Segreto Oscuro Diablerista 3 - Esclusione di preda: Mortali";
                }
                else { DifettoPredatore = "Segreto Oscuro Evitato 3 - Esclusione di preda: Mortali"; }
            }

            if (Predator == "Simulante")
            {
                Random RandomSpecialPredatore = new Random();
                int randomSpecialPredatore = RandomSpecialPredatore.Next(0, 5);
                if (randomSpecialPredatore == 0) { SpecialPredatore = "Convincere: Disorientare"; }
                else if (randomSpecialPredatore == 1) { SpecialPredatore = "Sotterfugio: Insabbiare"; }
                else if (randomSpecialPredatore == 2) { SpecialPredatore = "Convincere: Disorientare"; }
                else if (randomSpecialPredatore == 3) { SpecialPredatore = "Sotterfugio: Insabbiare"; }
                Random RandomPowerPredatore = new Random();
                int randomPowerPredatore = RandomPowerPredatore.Next(0, 5);
                if (randomPowerPredatore == 0) { SpecialPredatore = "Animalità 1"; }
                else if (randomPowerPredatore == 1) { PowerPredatore = "Dominazione 1"; }
                else if (randomPowerPredatore == 2) { PowerPredatore = "Animalità 1"; }
                else if (randomPowerPredatore == 3) { PowerPredatore = "Dominazione 1"; }
                PregioPredatore = "Gregge 3";
                DifettoPredatore = "Segreto Oscuro: Simulante 1";
            };

            if (Predator == "Sirena")
            {
                Random RandomSpecialPredatore = new Random();
                int randomSpecialPredatore = RandomSpecialPredatore.Next(0, 5);
                if (randomSpecialPredatore == 0)
                {
                    SpecialPredatore = "Convincere: Seduzione";
                    Console.WriteLine(SpecialPredatore);
                }
                else if (randomSpecialPredatore == 1)
                {
                    SpecialPredatore = "Sotterfugio: Seduzione";
                    Console.WriteLine(SpecialPredatore);
                }
                else if (randomSpecialPredatore == 2)
                {
                    SpecialPredatore = "Convincere: Seduzione";
                    Console.WriteLine(SpecialPredatore);
                }
                else if (randomSpecialPredatore == 3)
                {
                    SpecialPredatore = "Sotterfugio: Seduzione";
                    Console.WriteLine(SpecialPredatore);
                }
                Random RandomPowerPredatore = new Random();
                int randomPowerPredatore = RandomPowerPredatore.Next(0, 5);
                if (randomPowerPredatore == 0)
                {
                    SpecialPredatore = "Ascendente 1";
                }
                else if (randomPowerPredatore == 1) { PowerPredatore = "Robustezza 1"; }
                else if (randomPowerPredatore == 2)
                {
                    PowerPredatore = "Ascendente 1";
                }
                else if (randomPowerPredatore == 3)
                {
                    PowerPredatore = "Robustezza 1";
                }
                PregioPredatore = " Aspetto attraente 3";

                Random ChooseEnemy = new Random();
                int ChoosenEnemy = ChooseEnemy.Next(0, 4);
                if (ChoosenEnemy == 0 || ChoosenEnemy == 1)
                {
                    DifettoPredatore = " Nemico: un amante rifiutato";
                }
                else { DifettoPredatore = " Nemico: un partner geloso"; }
            };


            Console.WriteLine("Nome: " + Nome[NomePg] + "\t" + Cognome[CognomePg] + "\r\n");
            pgname = Nome[NomePg] + " " + Cognome[CognomePg];
            Console.WriteLine("Clan: " + Clan[Razza] + " - Predatore: " + Predator);
            sirename = Nome[NomeSireRandom] + " " + Cognome[CognomeSireRandom];
            if (Nome[NomeSireRandom] == Nome[NomePg] && Cognome[CognomePg]== Cognome[CognomeSireRandom])
            {
                Random NomeRandomSire = new Random();
                Random CognomeRandomSire = new Random();
                NomeSireRandom = NomeRandomSire.Next(Nome.Length);
                CognomeSireRandom = CognomeRandomSire.Next(Cognome.Length);
            }
                if (NomeSireRandom == CognomeSireRandom)
                {
                    Random CognomeRandomsire = new Random();
                    CognomeSireRandom = CognomeRandomsire.Next(Cognome.Length);
                }
            
                sirename = Nome[NomeSireRandom] + " " + Cognome[CognomeSireRandom];

            
            Console.WriteLine("\r\nSire: " + Nome[NomeSireRandom] + "\t" + Cognome[CognomeSireRandom] + "\r\n");
            Console.WriteLine("________");
            Console.WriteLine(" Attributi\r\n");


            // Creazione statistiche 
            while (dado.Count > 0)
            {
                // Lancio del dado 
                foreach (string Statistica in Statistiche)
                {
                    int index = rand.Next(dado.Count);
                    int numero = dado[index];
                    StatAssegnate.Add(new string[] { Statistica, numero.ToString() });
                    if (Statistica == "Costituzione")
                    {
                        Salute = numero + 3;
                    }
                    else if (Statistica == "Autocontrollo")
                    {
                        Autocontrollo = numero;
                    }
                    else if (Statistica == "Fermezza")
                    {
                        Fermezza = numero;
                    }
                    // Rimozione del numero dal dado 
                    dado.RemoveAt(index);

                }
            }
            Console.WriteLine("\r\n");
            Console.WriteLine("Salute " + Salute);
            Volontà = Fermezza + Autocontrollo;
            Console.WriteLine("Volontà" + Volontà);
            Console.WriteLine("________");


            //creazione abilita



            Console.WriteLine(" Abilità");
            int ModalitàInserimentoAbilità = Rand.Next(1, 4);
            if (ModalitàInserimentoAbilità == 1)
            {
                for (int i = 0; i < 19; i++)
                {
                    ChosenAbility = RandomAbility.Next(Abilità.Length);
                    while (isTaken[ChosenAbility])
                    {
                        ChosenAbility = RandomAbility.Next(Abilità.Length);
                    }
                    isTaken[ChosenAbility] = true;
                    int index = AbilityValue.Next(Tuttofare.Count);
                    int numero = Tuttofare[index];
                    if (Abilità[ChosenAbility] == "Accademiche")
                    {
                        int SpecialitaAccademica = RandomSpecialitaAccademica.Next(Accademiche.Length);
                        Console.WriteLine(Abilità[ChosenAbility] + " " + numero + " " + Accademiche[SpecialitaAccademica]);
                        AbilitàAssegnate.Add(new string[] { Abilità[ChosenAbility],numero.ToString(), Accademiche[SpecialitaAccademica] });
                    }
                    else if (Abilità[ChosenAbility] == "Manualità")
                    {
                        int SpecialitaManualità = RandomSpecialitaLavoriManuali.Next(LavoriManuali.Length);
                        Console.WriteLine(Abilità[ChosenAbility] + " " + numero + " " + LavoriManuali[SpecialitaManualità]);
                        AbilitàAssegnate.Add(new string[] { Abilità[ChosenAbility], numero.ToString(), LavoriManuali[SpecialitaManualità] });

                    }
                    else if (Abilità[ChosenAbility] == "Espressività")
                    {
                        int SpecialitaPerformance = RandomSpecialitaPerformance.Next(Espressività.Length);
                        Console.WriteLine(Abilità[ChosenAbility] + " " + numero + " " + Espressività[SpecialitaPerformance]);
                        AbilitàAssegnate.Add(new string[] { Abilità[ChosenAbility], numero.ToString(), Espressività[SpecialitaPerformance] });

                    }

                    else if (Abilità[ChosenAbility] == "Scienze")
                    {
                        int SpecialitaScienze = RandomSpecialitaScienze.Next(Scienze.Length);
                        Console.WriteLine(Abilità[ChosenAbility] + " " + numero + " " + Scienze[SpecialitaScienze]);
                        AbilitàAssegnate.Add(new string[] { Abilità[ChosenAbility], numero.ToString(), Scienze[SpecialitaScienze] });

                    }
                    else
                    {
                        Console.WriteLine(Abilità[ChosenAbility] + " " + numero);
                        AbilitàAssegnate.Add(new string[] { Abilità[ChosenAbility], numero.ToString(), "" });
                    }
                    Tuttofare.RemoveAt(index);
                }

            }
            else if (ModalitàInserimentoAbilità == 2)
            {
                for (int i = 0; i < 15; i++)
                {
                    ChosenAbility = RandomAbility.Next(Abilità.Length);
                    while (isTaken[ChosenAbility])
                    {
                        ChosenAbility = RandomAbility.Next(Abilità.Length);
                    }
                    isTaken[ChosenAbility] = true;
                    int index = AbilityValue.Next(Equilibrato.Count);
                    int numero = Equilibrato[index];
                    if (Abilità[ChosenAbility] == "Accademiche")
                    {
                        int SpecialitaAccademica = RandomSpecialitaAccademica.Next(Accademiche.Length);
                        Console.WriteLine(Abilità[ChosenAbility] + " " + numero + " " + Accademiche[SpecialitaAccademica]);
                        AbilitàAssegnate.Add(new string[] { Abilità[ChosenAbility], numero.ToString(), Accademiche[SpecialitaAccademica] });

                    }
                    else if (Abilità[ChosenAbility] == "Manualità")
                    {
                        int SpecialitaManualità = RandomSpecialitaLavoriManuali.Next(LavoriManuali.Length);
                        Console.WriteLine(Abilità[ChosenAbility] + " " + numero + " " + LavoriManuali[SpecialitaManualità]);
                    }
                    else if (Abilità[ChosenAbility] == "Espressività")
                    {
                        int SpecialitaPerformance = RandomSpecialitaPerformance.Next(Espressività.Length);
                        Console.WriteLine(Abilità[ChosenAbility] + " " + numero + " " + Espressività[SpecialitaPerformance]);
                    }

                    else if (Abilità[ChosenAbility] == "Scienze")
                    {
                        int SpecialitaScienze = RandomSpecialitaScienze.Next(Scienze.Length);
                        Console.WriteLine(Abilità[ChosenAbility] + " " + numero + " " + Scienze[SpecialitaScienze]);

                    }
                    else
                    {
                        Console.WriteLine(Abilità[ChosenAbility] + " " + numero);
                        AbilitàAssegnate.Add(new string[] { Abilità[ChosenAbility], numero.ToString(), "" });
                    }
                    Equilibrato.RemoveAt(index);
                }
            }
            else if (ModalitàInserimentoAbilità == 3)
            {
                for (int i = 0; i < 10; i++)
                {
                    ChosenAbility = RandomAbility.Next(Abilità.Length);
                    while (isTaken[ChosenAbility])
                    {
                        ChosenAbility = RandomAbility.Next(Abilità.Length);
                    }
                    isTaken[ChosenAbility] = true;
                    int index = AbilityValue.Next(Specializzato.Count);
                    int numero = Specializzato[index];
                    if (Abilità[ChosenAbility] == "Accademiche")
                    {
                        int SpecialitaAccademica = RandomSpecialitaAccademica.Next(Accademiche.Length);
                        _ChosenAbility = ChosenAbility;
                        Console.WriteLine(Abilità[ChosenAbility] + " " + numero + " " + Accademiche[SpecialitaAccademica]);
                        AbilitàAssegnate.Add(new string[] { Abilità[ChosenAbility], numero.ToString(), Accademiche[SpecialitaAccademica] });
                    }
                    else if (Abilità[ChosenAbility] == "Manualità")
                    {
                        int SpecialitaManualità = RandomSpecialitaLavoriManuali.Next(LavoriManuali.Length);
                        Console.WriteLine(Abilità[ChosenAbility] + " " + numero + " " + LavoriManuali[SpecialitaManualità]);
                        _ChosenAbility = ChosenAbility;
                        AbilitàAssegnate.Add(new string[] { Abilità[ChosenAbility], numero.ToString(), LavoriManuali[SpecialitaManualità] });
                    }
                    else if (Abilità[ChosenAbility] == "Espressività")
                    {
                        int SpecialitaPerformance = RandomSpecialitaPerformance.Next(Espressività.Length);
                        _ChosenAbility = ChosenAbility;
                        Console.WriteLine(Abilità[ChosenAbility] + " " + numero + " " + Espressività[SpecialitaPerformance]);
                        AbilitàAssegnate.Add(new string[] { Abilità[ChosenAbility], numero.ToString(), Espressività[SpecialitaPerformance] });
                    }

                    else if (Abilità[ChosenAbility] == "Scienze")
                    {
                        int SpecialitaScienze = RandomSpecialitaScienze.Next(Scienze.Length);
                        Console.WriteLine(Abilità[ChosenAbility] + " " + numero + " " + Scienze[SpecialitaScienze]);
                        AbilitàAssegnate.Add(new string[] { Abilità[ChosenAbility], numero.ToString(), Scienze[SpecialitaScienze] });
                    }
                    else
                    {
                        Console.WriteLine(Abilità[ChosenAbility] + " " + numero);
                        AbilitàAssegnate.Add(new string[] { Abilità[ChosenAbility], numero.ToString(), "" });
                    }
                    Specializzato.RemoveAt(index);

                }
            }

            Console.WriteLine("\r\n");
            Console.WriteLine("________");




            int Abilitàspecialitàrandom = AbilitàSpecialitàRandom.Next(AbilitàAssegnate.Count);
            string[] abltspeclist = AbilitàAssegnate[Abilitàspecialitàrandom];
            string AbltSpec = abltspeclist[0];
            Console.Write("Specialità Bonus: ");
            Console.Write(AbltSpec);
            if (AbltSpec == "Armi da fuoco")
            {
                int SpecialChoose = Spec.Next(ArmiDaFuoco.Length);
                Console.Write(" - " + ArmiDaFuoco[SpecialChoose]);
                AbilitàAssegnate.Add(new string[] { AbltSpec, ArmiDaFuoco[SpecialChoose]});

            }
            else if (AbltSpec == "Atletica")
            {
                int SpecialChoose = Spec.Next(Atletica.Length);
                Console.Write(" - " + Atletica[SpecialChoose]);
                AbilitàAssegnate.Add(new string[] { AbltSpec, Atletica[SpecialChoose] });

            }
            else if (AbltSpec == "Criminalità")
            {
                int SpecialChoose = Spec.Next(Criminalità.Length);
                Console.Write(" - " + Criminalità[SpecialChoose]);
                AbilitàAssegnate.Add(new string[] { AbltSpec, Criminalità[SpecialChoose] });
            }
            else if (AbltSpec == "Furtività")
            {
                int SpecialChoose = Spec.Next(Furtività.Length);
                Console.Write(" - " + Furtività[SpecialChoose]);
                AbilitàAssegnate.Add(new string[] { AbltSpec, Furtività[SpecialChoose] });

            }
            else if (AbltSpec == "Guidare")
            {
                int SpecialChoose = Spec.Next(Guidare.Length);
                Console.Write(" - " + Guidare[SpecialChoose]);
                AbilitàAssegnate.Add(new string[] { AbltSpec, Guidare[SpecialChoose] });

            }
            else if (AbltSpec == "Manualità")
            {
                int SpecialChoose = Spec.Next(LavoriManuali.Length);
                while (SpecialChoose == _ChosenAbility)
                {
                    SpecialChoose = Spec.Next(LavoriManuali.Length);
                }
                Console.Write(" - " + LavoriManuali[SpecialChoose]);
                string[] foundArray = AbilitàAssegnate.Find(array => array.Contains(AbltSpec));
                 indexAA = AbilitàAssegnate.FindIndex(array => array.Contains(AbltSpec));
                Array.Resize(ref foundArray, foundArray.Length + 1);
                foundArray[foundArray.Length-1] = LavoriManuali[SpecialChoose];
                AbilitàAssegnate[indexAA] = foundArray;
            }
            else if (AbltSpec == "Mischia")
            {
                int SpecialChoose = Spec.Next(Mischia.Length);
                Console.Write(" - " + Mischia[SpecialChoose]);
                AbilitàAssegnate.Add(new string[] { AbltSpec, Mischia[SpecialChoose] });

            }
            else if (AbltSpec == "Rissa")
            {
                int SpecialChoose = Spec.Next(Rissa.Length);
                Console.Write(" - " + Rissa[SpecialChoose]);
                AbilitàAssegnate.Add(new string[] { AbltSpec, Rissa[SpecialChoose] });

            }
            else if (AbltSpec == "Sopravvivenza")
            {
                int SpecialChoose = Spec.Next(Sopravvivenza.Length);
                Console.Write(" - " + Sopravvivenza[SpecialChoose]);
                AbilitàAssegnate.Add(new string[] { AbltSpec, Sopravvivenza[SpecialChoose] });

            }
            else if (AbltSpec == "Affinità Animale")
            {
                int SpecialChoose = Spec.Next(AffinitaAnimale.Length);
                Console.Write(" - " + AffinitaAnimale[SpecialChoose]);
                AbilitàAssegnate.Add(new string[] { AbltSpec, AffinitaAnimale[SpecialChoose] });

            }
            else if (AbltSpec == "Autorità")
            {
                int SpecialChoose = Spec.Next(Autorità.Length);
                Console.Write(" - " + Autorità[SpecialChoose]);
                AbilitàAssegnate.Add(new string[] { AbltSpec, Autorità[SpecialChoose] });
            }
            else if (AbltSpec == "Bassifondi")
            {
                int SpecialChoose = Spec.Next(Bassifondi.Length);
                Console.Write(" - " + Bassifondi[SpecialChoose]);
                AbilitàAssegnate.Add(new string[] { AbltSpec, Bassifondi[SpecialChoose] });
            }
            else if (AbltSpec == "Convincere")
            {
                int SpecialChoose = Spec.Next(Convincere.Length);
                Console.Write(" - " + Convincere[SpecialChoose]);
                AbilitàAssegnate.Add(new string[] { AbltSpec, Convincere[SpecialChoose] });
            }
            else if (AbltSpec == "Espressività")
            {
                int SpecialChoose = Spec.Next(LavoriManuali.Length);
                while (SpecialChoose == _ChosenAbility)
                {
                    SpecialChoose = Spec.Next(LavoriManuali.Length);
                }
                Console.Write(" - " + LavoriManuali[SpecialChoose]);
                string[] foundArray = AbilitàAssegnate.Find(array => array.Contains(AbltSpec));
                 indexAA = AbilitàAssegnate.FindIndex(array => array.Contains(AbltSpec));
                Array.Resize(ref foundArray, foundArray.Length + 1);
                foundArray[foundArray.Length - 1] = LavoriManuali[SpecialChoose];
                AbilitàAssegnate[indexAA] = foundArray;
            }
            else if (AbltSpec == "Galateo")
            {
                int SpecialChoose = Spec.Next(Galateo.Length);
                Console.Write(" - " + Galateo[SpecialChoose]);
                AbilitàAssegnate.Add(new string[] { AbltSpec, Galateo[SpecialChoose] });
            }
            else if (AbltSpec == "Intimidire")
            {
                int SpecialChoose = Spec.Next(Intimidire.Length);
                Console.Write(" - " + Intimidire[SpecialChoose]);
                AbilitàAssegnate.Add(new string[] { AbltSpec, Intimidire[SpecialChoose] });
            }
            else if (AbltSpec == "Intuito")
            {
                int SpecialChoose = Spec.Next(Intuito.Length);
                Console.Write(" - " + Intuito[SpecialChoose]);
                AbilitàAssegnate.Add(new string[] { AbltSpec, Intuito[SpecialChoose] });
            }
            else if (AbltSpec == "Sotterfugio")
            {
                int SpecialChoose = Spec.Next(Sotterfugio.Length);
                Console.Write(" - " + Sotterfugio[SpecialChoose]);
                AbilitàAssegnate.Add(new string[] { AbltSpec, Sotterfugio[SpecialChoose] });
            }
            else if (AbltSpec == "Accademiche")
            {
                int SpecialChoose = Spec.Next(Accademiche.Length);
                while (SpecialChoose == _ChosenAbility)
                {
                    SpecialChoose = Spec.Next(Accademiche.Length);
                }
                Console.Write(" - " + Accademiche[SpecialChoose]);
                string[] foundArray = AbilitàAssegnate.Find(array => array.Contains(AbltSpec));
                 indexAA = AbilitàAssegnate.FindIndex(array => array.Contains(AbltSpec));
                Array.Resize(ref foundArray, foundArray.Length + 1);
                foundArray[foundArray.Length - 1] = Accademiche[SpecialChoose];
                AbilitàAssegnate[indexAA] = foundArray;
            }
            else if (AbltSpec == "Allerta")
            {
                int SpecialChoose = Spec.Next(Allerta.Length);
                Console.Write(" - " + Allerta[SpecialChoose]);
                AbilitàAssegnate.Add(new string[] { AbltSpec, Allerta[SpecialChoose] });

            }
            else if (AbltSpec == "Finanza")
            {
                int SpecialChoose = Spec.Next(Finanza.Length);
                Console.Write(" - " + Finanza[SpecialChoose]);
                AbilitàAssegnate.Add(new string[] { AbltSpec, Finanza[SpecialChoose] });

            }
            else if (AbltSpec == "Investigare")
            {
                int SpecialChoose = Spec.Next(Investigare.Length);
                Console.Write(" - " + Investigare[SpecialChoose]);
                AbilitàAssegnate.Add(new string[] { AbltSpec, Investigare[SpecialChoose] });

            }
            else if (AbltSpec == "Medicina")
            {
                int SpecialChoose = Spec.Next(Medicina.Length);
                Console.Write(" - " + Medicina[SpecialChoose]);
                AbilitàAssegnate.Add(new string[] { AbltSpec, Medicina[SpecialChoose] });

            }
            else if (AbltSpec == "Occulto")
            {
                int SpecialChoose = Spec.Next(Occulto.Length);
                Console.Write(" - " + Occulto[SpecialChoose]);
                AbilitàAssegnate.Add(new string[] { AbltSpec, Occulto[SpecialChoose] });

            }
            else if (AbltSpec == "Politica")
            {
                int SpecialChoose = Spec.Next(Politica.Length);
                Console.Write(" - " + Politica[SpecialChoose]);
                AbilitàAssegnate.Add(new string[] { AbltSpec, Politica[SpecialChoose] });

            }
            else if (AbltSpec == "Scienze")
            {
                int SpecialChoose = Spec.Next(LavoriManuali.Length);
                while (SpecialChoose == _ChosenAbility)
                {
                    SpecialChoose = Spec.Next(LavoriManuali.Length);
                }
                Console.Write(" - " + LavoriManuali[SpecialChoose]);
                string[] foundArray = AbilitàAssegnate.Find(array => array.Contains(AbltSpec));
                 indexAA = AbilitàAssegnate.FindIndex(array => array.Contains(AbltSpec));
                Array.Resize(ref foundArray, foundArray.Length + 1);
                foundArray[foundArray.Length - 1] = LavoriManuali[SpecialChoose];
                AbilitàAssegnate[indexAA] = foundArray;

            }
            else if (AbltSpec == "Tecnologia")
            {
                int SpecialChoose = Spec.Next(Tecnologia.Length);
                Console.WriteLine(" - " + Tecnologia[SpecialChoose]);
                AbilitàAssegnate.Add(new string[] { AbltSpec, Tecnologia[SpecialChoose] });

            }
            Console.WriteLine(" \nSpecialità predatore:" + SpecialPredatore + " \nPotere Bonus: " + PowerPredatore + " \nPregi: " + PregioPredatore + " - Difetti: " + DifettoPredatore);

            Console.WriteLine("\n");












            Console.WriteLine("\r\n");
            Console.WriteLine("________");
            Console.WriteLine(" Poteri\r\n");


            //scelta poteri     


            if (Clan[Razza] == "BANU HAQIM")
            {
                clanname = Clan[Razza];
                string[] Poteri = { "Blood Sorcery", "Celerity", "Obfuscate" };
                while (PowerValue.Count > 0)
                {
                    // Lancio del dado 
                    foreach (string Potere in Poteri)
                    {
                        int index = RandomPowerValue.Next(PowerValue.Count);
                        int numero = PowerValue[index];
                        Console.WriteLine(Potere + " " + numero);
                        poteri[i] = Potere + " " + numero;
                        i++;
                        PowerValue.RemoveAt(index);
                    }
                }
            }
            if (Clan[Razza] == "BRUJAH")
            {
                clanname = Clan[Razza];
                string[] Poteri = { "Celerity", "Potence", "Presence" };
                while (PowerValue.Count > 0)
                {
                    // Lancio del dado 
                    foreach (string Potere in Poteri)
                    {
                        int index = RandomPowerValue.Next(PowerValue.Count);
                        int numero = PowerValue[index];
                        Console.WriteLine(Potere + " " + numero);
                        poteri[i] = Potere + " " + numero;
                        i++;
                        PowerValue.RemoveAt(index);
                    }
                }
            }
            if (Clan[Razza] == "GANGREL")
            {
                clanname = Clan[Razza];
                string[] Poteri = { "Animalism", "Fortitude", "Protean" };
                while (PowerValue.Count > 0)
                {
                    // Lancio del dado 
                    foreach (string Potere in Poteri)
                    {
                        int index = RandomPowerValue.Next(PowerValue.Count);
                        int numero = PowerValue[index];
                        Console.WriteLine(Potere + " " + numero);
                        poteri[i] = Potere + " " + numero;
                        i++;
                        PowerValue.RemoveAt(index);
                    }
                }
            }
            if (Clan[Razza] == "HECATA")
            {
                clanname = Clan[Razza];
                string[] Poteri = { "Auspex", "Fortitude", "Oblivion" };
                while (PowerValue.Count > 0)
                {
                    // Lancio del dado 
                    foreach (string Potere in Poteri)
                    {
                        int index = RandomPowerValue.Next(PowerValue.Count);
                        int numero = PowerValue[index];
                        Console.WriteLine(Potere + " " + numero);
                        poteri[i] = Potere + " " + numero;
                        i++;
                        PowerValue.RemoveAt(index);
                    }
                }
            }
            if (Clan[Razza] == "LASOMBRA")
            {
                clanname = Clan[Razza];
                string[] Poteri = { "Dominate", "Oblivion", "Potence" };
                while (PowerValue.Count > 0)
                {
                    // Lancio del dado 
                    foreach (string Potere in Poteri)
                    {
                        int index = RandomPowerValue.Next(PowerValue.Count);
                        int numero = PowerValue[index];
                        Console.WriteLine(Potere + " " + numero);
                        poteri[i] = Potere + " " + numero;
                        i++;
                        PowerValue.RemoveAt(index);
                    }
                }
            }
            if (Clan[Razza] == "MALKAVIAN")
            {
                clanname = Clan[Razza];
                string[] Poteri = { "Auspex", " Dominate", "Obfuscate" };
                while (PowerValue.Count > 0)
                {
                    // Lancio del dado 
                    foreach (string Potere in Poteri)
                    {
                        int index = RandomPowerValue.Next(PowerValue.Count);
                        int numero = PowerValue[index];
                        Console.WriteLine(Potere + " " + numero);
                        poteri[i] = Potere + " " + numero;
                        i++;
                        PowerValue.RemoveAt(index);
                    }
                }
            }

            if (Clan[Razza] == "SETITI")
            {
                clanname = Clan[Razza];
                string[] Poteri = { "Obfuscate", "Presence", "Protean" };
                while (PowerValue.Count > 0)
                {
                    // Lancio del dado 
                    foreach (string Potere in Poteri)
                    {
                        int index = RandomPowerValue.Next(PowerValue.Count);
                        int numero = PowerValue[index];
                        Console.WriteLine(Potere + " " + numero);
                        poteri[i] = Potere + " " + numero;
                        i++;
                        PowerValue.RemoveAt(index);
                    }
                }
            }

            if (Clan[Razza] == "NOSFERATU")
            {
                clanname = Clan[Razza];
                string[] Poteri = { "Animalism", "Obfuscate", "Potence" };
                while (PowerValue.Count > 0)
                {
                    // Lancio del dado 
                    foreach (string Potere in Poteri)
                    {
                        int index = RandomPowerValue.Next(PowerValue.Count);
                        int numero = PowerValue[index];
                        Console.WriteLine(Potere + " " + numero);
                        poteri[i] = Potere + " " + numero;
                        i++;
                        PowerValue.RemoveAt(index);
                    }
                }
            }
            if (Clan[Razza] == "RAVNOS")
            {
                clanname = Clan[Razza];
                string[] Poteri = { "Animalism", "Obfuscate", "Presence" };
                while (PowerValue.Count > 0)
                {
                    // Lancio del dado 
                    foreach (string Potere in Poteri)
                    {
                        int index = RandomPowerValue.Next(PowerValue.Count);
                        int numero = PowerValue[index];
                        Console.WriteLine(Potere + " " + numero);
                        poteri[i] = Potere + " " + numero;
                        i++;
                        PowerValue.RemoveAt(index);
                    }
                }
            }
            if (Clan[Razza] == "SALUBRI")
            {
                clanname = Clan[Razza];
                string[] Poteri = { "Auspex", "Dominate", "Forritude" };
                while (PowerValue.Count > 0)
                {
                    // Lancio del dado 
                    foreach (string Potere in Poteri)
                    {
                        int index = RandomPowerValue.Next(0, (PowerValue.Count - 1));
                        int numero = PowerValue[index];
                        Console.WriteLine(Potere + " " + numero);
                        poteri[i] = Potere + " " + numero;
                        i++;
                        PowerValue.RemoveAt(index);
                    }
                }
            }
            if (Clan[Razza] == "TOREADOR")
            {
                clanname = Clan[Razza];
                string[] Poteri = { "Auspex", "Celerity", "Presence" };
                while (PowerValue.Count > 0)
                {
                    // Lancio del dado 
                    foreach (string Potere in Poteri)
                    {
                        int index = RandomPowerValue.Next(PowerValue.Count);
                        int numero = PowerValue[index];
                        Console.WriteLine(Potere + " " + numero);
                        poteri[i] = Potere + " " + numero;
                        i++;
                        PowerValue.RemoveAt(index);
                    }
                }
            }
            if (Clan[Razza] == "TREMERE")
            {
                clanname = Clan[Razza];
                string[] Poteri = { "Auspex", "Blood Sorcery", "Dominate" };
                while (PowerValue.Count > 0)
                {
                    // Lancio del dado 
                    foreach (string Potere in Poteri)
                    {
                        int index = RandomPowerValue.Next(PowerValue.Count);
                        int numero = PowerValue[index];
                        Console.WriteLine(Potere + " " + numero);
                        poteri[i] = Potere + " " + numero;
                        i++;
                        PowerValue.RemoveAt(index);
                    }
                }
            }
            if (Clan[Razza] == "TZIMISCE")
            {
                clanname = Clan[Razza];
                string[] Poteri = { "Animalism", "Dominate", "Protean" };
                while (PowerValue.Count > 0)
                {
                    // Lancio del dado 
                    foreach (string Potere in Poteri)
                    {
                        int index = RandomPowerValue.Next(PowerValue.Count);
                        int numero = PowerValue[index];
                        Console.WriteLine(Potere + " " + numero);
                        poteri[i] = Potere + " " + numero;
                        i++;
                        PowerValue.RemoveAt(index);
                    }
                }
            }
            if (Clan[Razza] == "VENTRUE")
            {
                clanname = Clan[Razza];
                string[] Poteri = { "Dominate", "Fortitude", "Presence" };
                while (PowerValue.Count > 0)
                {
                    // Lancio del dado 
                    foreach (string Potere in Poteri)
                    {
                        int index = RandomPowerValue.Next(PowerValue.Count);
                        int numero = PowerValue[index];
                        Console.WriteLine(Potere + " " + numero);
                        poteri[i] = Potere + " " + numero;
                        i++;
                        PowerValue.RemoveAt(index);
                    }
                }
            }
            if (Clan[Razza] == "SANGUE DEBOLE")
            {
                clanname = Clan[Razza];
                string[] Poteri = { "Animalism", "Auspex", "Blood Sorcery", "Celerity", "Dominate", "Fortitude", "Obfuscate", "Oblivion", "Potence", "Presence", "Protean", "Thin-Blood Alchemy" };
                while (PowerValue.Count > 0)
                {
                    // Lancio del dado 
                    int ChosenSangueDebolePower = SangueDebolePower.Next(Poteri.Length);
                    int index = RandomPowerValue.Next(PowerValue.Count);
                    int numero = PowerValue[index];
                    Console.WriteLine(Poteri[ChosenSangueDebolePower] + " " + numero);
                    poteri[i] = Poteri[ChosenSangueDebolePower] + " " + numero;
                    i++;
                    PowerValue.RemoveAt(index);

                }
            }
            if (Clan[Razza] == "CAITIFF")
            {
                clanname = Clan[Razza];
                string[] Poteri = { "Animalism", "Auspex", "Blood Sorcery", "Celerity", "Dominate", "Fortitude", "Obfuscate", "Oblivion", "Potence", "Presence", "Protean", };
                while (PowerValue.Count > 0)
                {
                    // Lancio del dado 
                    int ChosenSangueDebolePower = SangueDebolePower.Next(Poteri.Length);
                    int index = RandomPowerValue.Next(PowerValue.Count);
                    int numero = PowerValue[index];
                    poteri[i] = Poteri[ChosenSangueDebolePower] + " " + numero;
                    Console.WriteLine(Poteri[ChosenSangueDebolePower] + " " + numero);
                    PowerValue.RemoveAt(index);
                    i++;
                }
            }
            Console.WriteLine("________");
            int nr = FameRandom.Next(0, 6);
            int Nr = UmanitàRandom.Next(1, 9);
            NumUmanità = NumUmanità + Nr;
            Console.WriteLine("Fame " + nr + "\t" + " Umanità " + NumUmanità);
            return "dog";
        }
    }
}
