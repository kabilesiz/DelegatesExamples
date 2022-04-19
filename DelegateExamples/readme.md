# Delegate Examples
Bu projede Action, Func ve Predicate delegelerini ele alacağız. Temel bazda hepsi birer delege(fonksiyon) davranışı gösterirler. Birbirlerinden farklarını aşşağıda anlatacağım.

## Genel Bakış

### Action
- Syntax : **Action<T> action**
- Action dönüş tipi olmayan (void) delegelerdir. Syntax dan anlaşıalacağı Tresult parametresi almamaktadır.

### Func
- Syntax : **Func<in T1, in T2, out TResult>**
- Func dönüş tipi generic olan delegelerdir. Syntax dan anlaşılacağı Tresult parametresi bize Func delegesinin dönüş tipini göstermektedir


### Predicate
- Syntax : **Predicate<T>**
- Predicate dönüş tipi bool olan delegelerdir. Syntax dan anlaşılacağı Tresult paremetresi almaz fakat Action dan farklı olarak biz biliriz ki bir delege eğer Predicate ise dönüş tipi kesinlikle bool'dur. (Bu delegeye özel olarak Extension class yapısı kullandım List<Product> için IsExistAsPredicate methodunu extension olarak kullanmayı tercih ettim.)

## Proje içerisindeki Bakış
Proje kapsamında console uygulaması kullanılmıştır. Delegates classı extension classı olarak kullanılmıştır. Delegates classı içerisinde:
- static olarak __GetTotalPriceAsFunc__ methodu Function delegesi için implemente edilmiştir. 
- static olarak __GetTotalPriceAsAction__ methodu Action delegesi için implemente edilmiştir. 
- static olarak __IsMacbookProAsPredicate__ methodu Predicate delegesi için implemente edilmiştir. [Gönderilen string "Macbook Pro" mu değil mi kontrolunu yapıyor]
- static olarak __IsExistAsPredicate__ methodu extension method olarak implemente edilmiştir. [List<Products> içerisinde ki productların herhangi birtanesinin name değeri "Macbook Pro" mu değil mi kontrolunu yapıyor]


Proje çalıştırıldıgında console üzerindeki loglar takip edilerek gerçekleşen işlemlere ait sonuçların takibi mümkün dür.
![Delegate Example](delegateExample.png)

