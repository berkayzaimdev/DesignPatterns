using DesignPatterns.StrategyPattern;
using DesignPatterns.StrategyPattern.Strategies.Concrete;

var p1 = new Player("Beyaz Taşlar",new AttackingStrategy());
p1.ApplyGameplayStrategy();

var p2 = new Player("Siyah Taşlar",new DefencingStrategy());
p2.ApplyGameplayStrategy();


// Anlaşılması nispeten daha basit olan bu tasarım desenini yol haritasına benzetebiliriz.
// Okula gitmek için 3 seçeneğim var; (Otobüs -> Marmaray -> Metro), (Tramvay -> Metro -> Marmaray -> Metro), (Otobüs -> Metrobüs -> Metro)
// Bu 3 seçenekten birini; hatlardaki duruma, trafiğe, hava durumuna ve saate göre seçebilirim.
// Strategy Pattern mantığı ise burada devreye giriyor. Seçtiğim yol haritasına göre nesne davranışını belirleyebiliyorum.
// Özetle hedefimize gitmek istediğimiz stratejiyi seçerek, nesne üzerine uyguluyoruz.