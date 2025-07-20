using UnityEngine;

public class Fikirler : MonoBehaviour
{
    /// Abassy Wall
    /// Savaþý kaybetiþ bir komutanýz. Kral geçmiþ zaferlerimizden dolayý bizi idam etmez ama ceza olarak Abassy Wall'a sürgün eder.
    /// Abassy Wall'de desteksiz bir þekilde yýkýlmýþ bir þehir ve duvar ile savaþmamýz gerekir. Çünkü savaþý kaybedersek tüm abassy varlýklarý yukarý çýkacaktýr.
    /// Canavarlarla biz savaþýrýz ve arada bir gelen tüccarlar ile ticaret yaparak silah, elbise alýrýz.
    /// Bu sýrada gelen askerleri paralý asker olarak kullanabiliriz.
    /// Duvarý tamir ederek savunmamýzý güçlendiririz, böylelikle düþmana karþý zaman kazanmýþ oluruz.
    /// Þehrimizi tamir ederek gelen usta ve tüccarlarýn sayýsý ve yeteneðini arttýrarak þehrimizi dahada güçlendiririrz.
    /// Arada bir þehrimize sýkýntýlar baþ gösterebilir mesela kral tarafýndan gelen vergi memurlarý, haydutlar, canavarlar, doðal afetler gibi.
    /// Duvarýn önünde, üstünde ve arkasýnda olmak üzere 3 tip asker yerleþimi vardýr.
    /// Asker alanýndan çýkan asker ilk baþlarda oraya ýþýnlanýr ama sonra oraya koþar.
    /// Duvar çok kötü durumdadýr ancak zamanla kýsa süreliðine bizimle gelen usta onu düzeltir. Kullanýlan maddeler ne kadar iyiyse duvsr o kadar saðlam olur.
    /// 
    /// Ustalarýn istediði dükkan ne kadar iyi ve doluysa çýkan ürün o kadar iyi olacaktýr.
    /// Ustalarýn kullandýðý dükkan ve aletlerin kendi levelleri vardýr. Aletlerin leveli dükkanla ayný veya üstünde ise dükkana exp kazandýrýr.
    /// Aletler ustanýn levelinden yukarýdaysa usta exp kazanýr ve level atlar.
    /// Her dükkan kendine özgüdür ve içinde olacak aletler bellidir ancak levelleri oyuncunun satýn almasýna baðlýdýr.
    /// Aletler usta ile ne kadar yakýn ve üstse çýkan ürün o kadar kaliteli olur. Ne kadar yukardaysa baþarý o kadar düþük sansla olur.
    /// Askerler bu elbiseler ve silahlar ile daha güçlü olacaktýr.
    /// Askerler belli bir sayýya gelince bölük olarak onlarý Abassy alanýna gönderebiliriz. Böylelikle oradan normalden daha kaliteli ürünler elde edebiliriz.
    /// Abassy kýsmýna giden askerlerin durumu þansa baðlýdýr. Hepsi ve ya kýsmen geri dönebilir veya ölebilirler.
    /// Askerler
    /// Okçu -> Ok + Yay + Kumaþ elbise -> Terzi + Okçu
    /// Mýzrakçý ->  Mýzrak Ucu + Mýzrak Gövdesi + Kumaþ elbise -> Terzi + Mýzrakçý
    /// Topuz Adam ->  Topuz + Deri -> Derici + Öküz Alaný + Demirci
    /// Crossbow ->  Crossbow + Ok + Deri -> Derici + Öküz Alaný + Okçu
    /// Halberd ->  Halberd + Deri -> Demirci + Öküz Alaný + Derici
    /// Kýlýçlý ->  Kýlýç + Kalkan + Zýrh -> Demirci
    /// Süvari ->  Kýlýç + Zýrh + At -> Demirci + Ahýr
    /// Mühendis -> Kaðýt, Kalem, Kitap + Kumaþ elbise -> Terzi + Okul
    /// Büyücü -> Mana Taþý + Kumaþ elbise + Kitap -> Simya + Terzi + Okul
    /// Duvarýn üstüne savunma kalýplarý konabilir ancak bunlar malzemeleri sürekli kullanmak isterler ve duvara baský uygularlar buda duvarý yýpratýr.
    /// 
}