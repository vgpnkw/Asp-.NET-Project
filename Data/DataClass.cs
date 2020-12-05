using System;
using System.Collections.Generic;
using System.Linq;
using WikiPedia.Models;

namespace WikiPedia.Data
{
    public class DataClass
    {
        public static void Initialize(PublicationContext context)
        {
            if (!context.Publications.Any())
            {
                context.Publications.AddRange(
                    new Publication
                    {
                        Name = "Михаил Лермонтов",
                        ShirtInfo = "Михаи́л Юрьевич Лермонтов — русский поэт, прозаик, драматург, художник.",
                        Info = "Михаи́л Юрьевич Лермонтов (3  октября 1814, Москва — 15  июля 1841, Пятигорск) — русский поэт, прозаик, драматург, художник. Творчество Лермонтова, в котором сочетаются гражданские, философские и личные мотивы, отвечавшие насущным потребностям духовной жизни русского общества, ознаменовало собой новый расцвет русской литературы и оказало большое влияние на виднейших русских писателей и поэтов XIX и XX веков. Произведения Лермонтова получили большой отклик в живописи, театре, кинематографе. Его стихи стали подлинным кладезем для оперного, симфонического и романсового творчества. Многие из них стали народными песнями.",
                        ImageName = "lermontov",

                        Parts = new List<PartInfo>()
                        {
                            new PartInfo
                            {
                                PartName  = "Семья",
                                Text = "Род Лермонтовых происходил из Шотландии и восходил к полумифическому барду-пророку Томасу Лермонту. В 1613 году один из представителей этого рода, поручик польской армии Георг (Джордж) Лермонт (около 1596—1633 или 1634 года), был взят в плен войсками князя Дмитрия Пожарскогопри капитуляции польско-литовского гарнизона крепости Белая и в числе прочих так называемых «бельских немцев» поступил на службу к царю Михаилу Фёдоровичу. Лермонт перешёл в православие и стал, под именем Юрия Андреевича, родоначальником русской дворянской фамилии Лермонтовых. В чине ротмистра русского рейтарского строя он погиб при осаде Смоленска. Британская компания Oxford Ancestors, составляющая генеалогические древа, провела работу по проверке данной версии происхождения Лермонтова при помощи анализа ДНК. Однако обнаружить родство между современными британскими Лермонтами и потомками Михаила Лермонтова не удалось. В то же время основатель Oxford Ancestors Брайан Сайкс подчеркнул, что общие характеристики Y-хромосомы русского потомка М. Ю Лермонтова вполне согласуются с шотландским происхождением." +
"Своим предполагаемым шотландским корням Лермонтов посвятил стихотворение «Желание» (1831). В юности Лермонтов ассоциировал свою фамилию с испанским государственным деятелем начала XVII века Франсиско Лермой. Эти фантазии отразились в написанном поэтом воображаемом портрете Лермы, а также в драме «Испанцы» (1830)."+
"Прадед поэта Юрий Петрович Лермонтов закончил Сухопутный шляхетский кадетский корпус, с 1767 года — секунд-майор. Род Лермонтовых был состоятельным, но впоследствии пришёл в упадок."+
"Отец поэта, также Юрий Петрович Лермонтов (1787—1831), перед женитьбой на Марии Михайловне Арсеньевой вышел в отставку в чине пехотного капитана. По воспоминаниям, собранным чембарским краеведом П. К. Шугаевым (1855—1917), он «был среднего роста, редкий красавец и прекрасно сложён; в общем, его можно назвать в полном смысле слова изящным мужчиной; он был добр, но ужасно вспыльчив». У Юрия Петровича были сёстры, родные тётки поэта, проживавшие в Москве.",

                                   PatrImageName = "lermontov_family",
                            },
                            new PartInfo
                            {
                                PartName = "Первое пребывание на Кавказе и его влияние на творчество",
                                Text = "Первое пребывание Лермонтова на Кавказе длилось всего несколько месяцев. Благодаря хлопотам бабушки он был сначала переведён с возвращённым чином корнета в лейб-гвардии Гродненский гусарский полк, расположенный в Новгородской губернии, а потом — в апреле 1838 года — переведён в Лейб-гвардии Гусарский Его Величества полк. С полком Лермонтов проехал также по территории Азербайджана (Шуша(Нуха?), Куба, Шемахы). Несмотря на кратковременность службы на Кавказе, Лермонтов успел сильно измениться в нравственном отношении. Впечатления от природы Кавказа, жизни горцев, кавказский фольклор легли в основу многих произведений Лермонтова." +
"Природа приковала всё его внимание; он готов «целую жизнь» сидеть и любоваться её красотой; общество будто утратило для него привлекательность, юношеская весёлость исчезла и даже светские дамы замечали «чёрную меланхолию» на его лице.Инстинкт поэта-психолога влёк его, однако, в среду людей. Его здесь мало ценили, ещё меньше понимали, но горечь и злость закипали в нём, и на бумагу ложились новые пламенные речи, в воображении складывались бессмертные образы. " +
"Лермонтов возвращается в петербургский «свет», снова играет роль льва, тем более, что за ним теперь ухаживают все любительницы знаменитостей и героев; но одновременно он обдумывает могучий образ, ещё в юности волновавший его воображение.Кавказ обновил давнишние грёзы; создаются «Демон» и «Мцыри». ",
                                PatrImageName = "kaukaz",

                            },

                        }
                    },
                    new Publication
                    {
                        Name = "Александр Пушкин",
                        ShirtInfo = "Алекса́ндр Серге́евич Пу́шкин — русский поэт, драматург и прозаик, заложивший основы русского реалистического направления, критик и теоретик литературы, историк, публицист; один из самых авторитетных литературных деятелей первой трети XIX века.",
                        Info = "Алекса́ндр Сергеевич Пушкин (26 мая [6 июня] 1799, Москва — 29 января [10 февраля] 1837, Санкт-Петербург) — русский поэт, драматург и прозаик, заложивший основы русского реалистического направления, критик и теоретик литературы, историк, публицист; один из самых авторитетных литературных деятелей первой трети XIX века.",

                        ImageName = "pushkin",

                        Parts = new List<PartInfo>()
                        {
                            new PartInfo
                            {
                                PartName = "Юность",
                                Text = "Шесть лет (1811—1817) Пушкин провёл в Царскосельском лицее, открытом 19 октября 1811 года. Здесь юный поэт пережил события Отечественной войны 1812 года. Здесь впервые открылся и был высоко оценён его поэтический дар. Воспоминания о годах, проведённых в Лицее, о лицейском братстве навсегда остались в душе поэта. " +
"Среди лицейских преподавателей Пушкина был профессор нравственных и политических наук А. П. Куницын, учившийся в Гетингенском университете и бывший близким со многими будущими декабристами. Пушкин на всю жизнь сохранил признательность Куницыну. Он — единственный из лицейских учителей, к которому Пушкин неоднократно обращался в стихах.",
                                PatrImageName = "pushkin_der",
                            },
                            new PartInfo
                            {
                                PartName = "Молодость",
                                Text = "Из лицея Пушкин был выпущен 9 июня 1817 года в чине коллежского секретаря (10-го класса, по Табели о рангах), 13 июня высочайшим указом был определён в Коллегию иностранных дел и 15 июня принёс присягу, подписав бланк клятвенного обещания императору. Он становится постоянным посетителем театра, принимает участие в заседаниях «Арзамаса» (принят он был туда заочно, ещё учеником Лицея), в 1819 годувступает в члены литературно-театрального общества «Зелёная лампа», которым руководит «Союз благоденствия» (см. Декабристы). Не участвуя в деятельности первых тайных организаций, Пушкин, тем не менее связан дружескими узами со многими активными членами декабристских обществ, пишет политические эпиграммы и стихи «К Чаадаеву» («Любви, надежды, тихой славы…», 1818), «Вольность» (1818), «Н. Я. Плюсковой» (1818), «Деревня» (1819), распространявшиеся в списках.",
                                PatrImageName = "pushkin_der",
                            },

                        }
                    }
                    //new Publication
                    //{
                    //    Name = "Byzantine Empire",
                    //    ShirtInfo = "Eastern part of Roman Empire",
                    //    Info =
                    //        "The Byzantine Empire, also referred to as the Eastern Roman Empire, or Byzantium, was the continuation of the Roman Empire in its eastern provinces during Late Antiquity and the Middle Ages, when its capital city was Constantinople (modern Istanbul, formerly Byzantium). It survived the fragmentation and fall of the Western Roman Empire in the 5th century AD and continued to exist for an additional thousand years until it fell to the Ottoman Empire in 1453.[1] During most of its existence, the empire was the most powerful economic, cultural, and military force in Europe. Byzantine Empire is a term created after the end of the realm; its citizens continued to refer to their empire simply as the Roman Empire (Greek: Βασιλεία Ῥωμαίων, tr. Basileía Rhōmaíōn; Latin: Imperium Romanum), or Romania (Greek: Ῥωμανία, romanized: Rhōmanía), and to themselves as Romans (Greek: Ῥωμαῖοι, romanized: Rhōmaîoi). Several signal events from the 4th to 6th centuries mark the period of transition during which the Roman Empire's Greek East and Latin West diverged. Constantine I (r. 324–337) reorganised the empire, made Constantinople the new capital and legalised Christianity. Under Theodosius I (r. 379–395), Christianity became the state religion and other religious practices were proscribed. In the reign of Heraclius (r. 610–641), the Empire's military and administration were restructured and adopted Greek for official use in place of Latin.",
                    //    ImageName = "ByzantIco",

                    //    Parts = new List<PartInfo>()
                    //    {
                    //        new PartInfo
                    //        {
                    //            PartName = "History",
                    //            Text =
                    //                "This history of the Byzantine Empire covers the history of the Eastern Roman Empire from late antiquity until the Fall of Constantinople in 1453 AD. Several events from the 4th to 6th centuries mark the transitional period during which the Roman Empire's east and west divided. In 285, the emperor Diocletian (r. 284–305) partitioned the Roman Empire's administration into eastern and western halves.[1] Between 324 and 330, Constantine I (r. 306–337) transferred the main capital from Rome to Byzantium, later known as Constantinople (City of Constantine) and Nova Roma (New Rome). Under Theodosius I (r. 379–395), Christianity became the Empire's official state religion and others such as Roman polytheism were proscribed. And finally, under the reign of Heraclius (r. 610–641), the Empire's military and administration were restructured and adopted Greek for official use instead of Latin. Thus, although it continued the Roman state and maintained Roman state traditions, modern historians distinguish Byzantium from ancient Rome insofar as it was oriented towards Greek rather than Latin culture, and characterised by Orthodox Christianity rather than Roman polytheism.",
                    //            PatrImageName = "RomanEmp1",
                    //        },
                    //        new PartInfo
                    //        {
                    //            PartName = "Economy",
                    //            Text =
                    //                "The Byzantine economy was among the most robust economies in the Mediterranean for many centuries. Constantinople was a prime hub in a trading network that at various times extended across nearly all of Eurasia and North Africa. Some scholars argue that, up until the arrival of the Arabs in the 7th century, the Eastern Roman Empire had the most powerful economy in the world. The Arab conquests, however, would represent a substantial reversal of fortunes contributing to a period of decline and stagnation. Constantine V's reforms (c. 765) marked the beginning of a revival that continued until 1204. From the 10th century until the end of the 12th, the Byzantine Empire projected an image of luxury, and the travelers were impressed by the wealth accumulated in the capital. All this changed with the arrival of the Fourth Crusade, which was an economic catastrophe. The Palaiologoi tried to revive the economy, but the late Byzantine state would not gain full control of either the foreign or domestic economic forces.",
                    //            PatrImageName = "RomanEmp1",
                    //        },

                    //    }
                    //},
                    //new Publication
                    //{
                    //    Name = "Ancient Carthage",
                    //    ShirtInfo = "Ancient Phoenician city-state",
                    //    Info =
                    //        "Carthage (/ˈkɑːrθədʒ/; Punic: 𐤒𐤓𐤕𐤟𐤇𐤃𐤔𐤕, romanized: Qart-ḥadašt, lit. 'New City'; Latin: Carthāgō) was an ancient Phoenician city-state and civilization located in present-day Tunisia. Founded around 814 BC as a colony of Tyre, within centuries it became the center of the Carthaginian Empire, a major commercial and maritime power that dominated the western Mediterranean until the mid third century BC.",
                    //    ImageName = "CarthageIco",

                    //    Parts = new List<PartInfo>()
                    //    {
                    //        new PartInfo
                    //        {
                    //            PartName = "History",
                    //            Text =
                    //                "The city of Carthage was founded in the 9th century BC on the coast of Northwest Africa, in what is now Tunisia, as one of a number of Phoenician settlements in the western Mediterranean created to facilitate trade from the city of Tyre on the coast of what is now Lebanon. The name of both the city and the wider republic that grew out of it, Carthage developed into a significant trading empire throughout the Mediterranean. The date from which Carthage can be counted as an independent power cannot exactly be determined, and probably nothing distinguished Carthage from the other Phoenician colonies in Northwest Africa and the Mediterranean during 800–700 BC. By the end of the 7th century BC, Carthage was becoming one of the leading commercial centres of the West Mediterranean region. After a long conflict with the emerging Roman Republic, known as the Punic Wars (264–146 BC), Rome finally destroyed Carthage in 146 BC. A Roman Carthage was established on the ruins of the first. Roman Carthage was eventually destroyed—its walls torn down, its water supply cut off, and its harbours made unusable—following its conquest by Arab invaders at the close of the 7th century. It was replaced by Tunis as the major regional centre, which has spread to include the ancient site of Carthage in a modern suburb.",
                    //            PatrImageName = "RomanEmp1",
                    //        },
                    //        new PartInfo
                    //        {
                    //            PartName = "Government and politics",
                    //            Text =
                    //                "Like most ancient societies, including the Phoenician city-states, Carthage was initially ruled as a monarchy, although modern scholars debate whether this stemmed from a misunderstanding by Greek writers. Traditionally, most Phoenician kings did not exercise absolute power, but consulted with a body of advisors called the Adirim (mighty ones), which was likely comprised of the wealthiest members of society, namely merchants.[121] Carthage seems to have been ruled by a similar body known as the Blm, made up of nobles responsible for all important matters of state, including religion, administration, and the military.[120] Within this cabal was a hierarchy topped by the dominant family, usually the wealthiest members of the merchant class, which had some sort of executive power. Records indicate that different families held power at different times, suggesting a nonhereditary system of government dependent on the support or approval of the consultative body.",
                    //            PatrImageName = "RomanEmp1",
                    //        },

                    //    }
                    //}
                    
                );
                context.SaveChanges();
            }

            if (!context.Pictures.Any())
            {
                context.Pictures.AddRange(
                    new Picture()
                    {
                        Name = "lermontov",
                        Path = "/Images/Mikhail_lermontov.jpg",
                    },
                    new Picture()
                    {
                        Name = "pushkin",
                        Path = "/Images/Pushkin.jpg",
                        Text = "О. А. Кипренский. Портрет А. С. Пушкина"
                    },
                    new Picture()
                    {
                        Name = "gogol",
                        Path = "/Images/gogol.jpg",
                        Text = "Овальный портрет Александра Иванова (1840—1841)"
                    },
                    new Picture()
                    {
                        Name = "tolstoy",
                        Path = "/Images/Tolstoy.jpg",
                    },
                    new Picture()
                    {
                        Name = "tolstoy_town",
                        Path = "/Images/tolstoy_town.jpg",
                    },
                    new Picture()
                    {
                        Name = "gogols_city",
                        Path = "/Images/gogols_city.jpg",
                    },
                    new Picture()
                    {
                        Name = "lermontov_family",
                        Path = "/Images/lermontov_family.gif",
                    },
                    new Picture()
                    {
                        Name = "kaukaz",
                        Path = "/Images/kaukaz.jpg",
                    },
                    new Picture()
                    {
                        Name = "pushkin_der",
                        Path = "/Images/Pushkin_derzhavin.jpg",
                        Text = "Пушкин на лицейском экзамене.Картина И.Репина(1911)"
                    },
                    new Picture()
                    {
                        Name = "pushkin_mol",
                        Path = "/Images/pushkin_mol.jpg",
                        Text = "«Пушкин и Гоголь»(художник Николай Алексеев)"
                    },
                    new Picture()
                    {
                        Name = "DefIco",
                        Path = "/Images/Def1.jpg",
                        Text = "«default"
                    }


                //new Picture()
                //{
                //    Name = "DefIcoPub",
                //    Path = "/Images/DefIcoPub.png",
                //},
                //new Picture()
                //{
                //    Name = "DefIcoPart",
                //    Path = "/Images/DefIcoPart.jpg",
                //    Text = "What a picture!"
                //}
                );
                context.SaveChanges();
            }
        }
    }
}
