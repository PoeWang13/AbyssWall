using UnityEngine;

public class Fikirler : MonoBehaviour
{
    /// Abassy Wall
    /// Sava�� kaybeti� bir komutan�z. Kral ge�mi� zaferlerimizden dolay� bizi idam etmez ama ceza olarak Abassy Wall'a s�rg�n eder.
    /// Abassy Wall'de desteksiz bir �ekilde y�k�lm�� bir �ehir ve duvar ile sava�mam�z gerekir. ��nk� sava�� kaybedersek t�m abassy varl�klar� yukar� ��kacakt�r.
    /// Canavarlarla biz sava��r�z ve arada bir gelen t�ccarlar ile ticaret yaparak silah, elbise al�r�z.
    /// Bu s�rada gelen askerleri paral� asker olarak kullanabiliriz.
    /// Duvar� tamir ederek savunmam�z� g��lendiririz, b�ylelikle d��mana kar�� zaman kazanm�� oluruz.
    /// �ehrimizi tamir ederek gelen usta ve t�ccarlar�n say�s� ve yetene�ini artt�rarak �ehrimizi dahada g��lendiririrz.
    /// Arada bir �ehrimize s�k�nt�lar ba� g�sterebilir mesela kral taraf�ndan gelen vergi memurlar�, haydutlar, canavarlar, do�al afetler gibi.
    /// Duvar�n �n�nde, �st�nde ve arkas�nda olmak �zere 3 tip asker yerle�imi vard�r.
    /// Asker alan�ndan ��kan asker ilk ba�larda oraya ���nlan�r ama sonra oraya ko�ar.
    /// Duvar �ok k�t� durumdad�r ancak zamanla k�sa s�reli�ine bizimle gelen usta onu d�zeltir. Kullan�lan maddeler ne kadar iyiyse duvsr o kadar sa�lam olur.
    /// 
    /// Ustalar�n istedi�i d�kkan ne kadar iyi ve doluysa ��kan �r�n o kadar iyi olacakt�r.
    /// Ustalar�n kulland��� d�kkan ve aletlerin kendi levelleri vard�r. Aletlerin leveli d�kkanla ayn� veya �st�nde ise d�kkana exp kazand�r�r.
    /// Aletler ustan�n levelinden yukar�daysa usta exp kazan�r ve level atlar.
    /// Her d�kkan kendine �zg�d�r ve i�inde olacak aletler bellidir ancak levelleri oyuncunun sat�n almas�na ba�l�d�r.
    /// Aletler usta ile ne kadar yak�n ve �stse ��kan �r�n o kadar kaliteli olur. Ne kadar yukardaysa ba�ar� o kadar d���k sansla olur.
    /// Askerler bu elbiseler ve silahlar ile daha g��l� olacakt�r.
    /// Askerler belli bir say�ya gelince b�l�k olarak onlar� Abassy alan�na g�nderebiliriz. B�ylelikle oradan normalden daha kaliteli �r�nler elde edebiliriz.
    /// Abassy k�sm�na giden askerlerin durumu �ansa ba�l�d�r. Hepsi ve ya k�smen geri d�nebilir veya �lebilirler.
    /// Askerler
    /// Ok�u -> Ok + Yay + Kuma� elbise -> Terzi + Ok�u
    /// M�zrak�� ->  M�zrak Ucu + M�zrak G�vdesi + Kuma� elbise -> Terzi + M�zrak��
    /// Topuz Adam ->  Topuz + Deri -> Derici + �k�z Alan� + Demirci
    /// Crossbow ->  Crossbow + Ok + Deri -> Derici + �k�z Alan� + Ok�u
    /// Halberd ->  Halberd + Deri -> Demirci + �k�z Alan� + Derici
    /// K�l��l� ->  K�l�� + Kalkan + Z�rh -> Demirci
    /// S�vari ->  K�l�� + Z�rh + At -> Demirci + Ah�r
    /// M�hendis -> Ka��t, Kalem, Kitap + Kuma� elbise -> Terzi + Okul
    /// B�y�c� -> Mana Ta�� + Kuma� elbise + Kitap -> Simya + Terzi + Okul
    /// Duvar�n �st�ne savunma kal�plar� konabilir ancak bunlar malzemeleri s�rekli kullanmak isterler ve duvara bask� uygularlar buda duvar� y�prat�r.
    /// 
}