using DesignPatterns.AdapterPattern.Adaptees;
using DesignPatterns.AdapterPattern.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern.Adapter
{
    public class TurkeyAdapter : IDuck
        // TurkeyAdapter sınıfı, burada karşımıza Duck interface'ini Turkey nesnesine uyarlamamızı sağlayan sınıf olarak karşımıza çıkıyor.

        // Adapter sınıf için, adaptör örneğini verebiliriz.
        // Ülkelerin kendine özgü priz yuvaları vardır. Başka bir ülkede olduğumuzu düşünelim. Telefonumuzu şarj etmek için şarj cihazını aldığımızda, yuvaların uyuşmadığını görürüz.
        // Bu problemi çözmek için ise; girişi şarj cihazımızın çıkışı ile eşleşen, çıkışı priz yuvası ile eşleşen bir adaptör kullanırız.
        // Bu bağlamda Adapter Tasarım Kalıbı, birbiri ile uyumlu olmayan Interface'lerin entegrasyonunu sağlar.
    {
        public ITurkey Turkey { get; set; }

        public TurkeyAdapter(ITurkey turkey)
        {
            Turkey = turkey;
        }

        public void Quack()
        {
            Turkey.Gobble();
        }

        public void Fly()
        {
            Turkey.Fly();
        }
    }
}
