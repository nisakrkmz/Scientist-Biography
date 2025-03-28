# Yapay Zeka Destekli 'Bilim İnsanları Hakkında Bilgi' Uygulaması

Bu repo, **Murat Yücedağ**'ın **C# .Net ile Yapay Zeka Entegrasyonları** kursu kapsamında geliştirilmiş bir projeyi içermektedir. Mevcut kursta **OpenAI API** kullanılarak bir **yapay zeka destekli yemek tarif öneri uygulaması** tasarlanmışken, bu projede kullanılan **prompt**'a bir **bilim insanı adı** girilmektedir. Girilen bilim insanının hayatı, projeleri ve katkıları hakkında bilgi alınmaktadır.

## Proje Amacı
Bu projede, kullanıcıdan alınan **bilim insanı adı** ile **OpenAI API** üzerinden bilgi sorgulaması yapılmaktadır. Yapay zeka, girilen bilim insanı hakkında kısa bir biyografi, önemli projeleri ve bu projelere dair açıklamalar sunmaktadır. Proje, bilim insanlarının çalışmalarını daha geniş bir kitleye tanıtmayı hedeflemektedir.

## Kullanılan Teknolojiler
- **C# (.NET)**: Uygulamanın ana geliştirme dili.
- **OpenAI API**: Yapay zeka ve doğal dil işleme için kullanılan ana servis.
- **.env Dosyası**: API anahtarının güvenli bir şekilde saklanması için kullanılır.
- **HttpClient**: API isteklerini yapmak için kullanılan araç.

## Özellikler
- **Bilim İnsanları Bilgisi**: Girilen bilim insanının hayatı, projeleri ve başarıları hakkında detaylı bilgi alabilirsiniz.
- **Gizlilik**: API anahtarı `.env` dosyasına yerleştirilmiştir ve bu dosya git tarafından izlenmemektedir.
- **Geliştirilmiş Prompt**: OpenAI API'ye gönderilen istekler, daha doğru ve anlamlı cevaplar almak için optimize edilmiştir.

## Kurulum ve Çalıştırma
Projenin çalıştırılması için aşağıdaki adımları takip edebilirsiniz:

### 1. Projeyi Klonlayın
```bash
git clone https://github.com/kullanıcı_adınız/proje_adı.git
```

### 2. API Anahtarını Yapılandırın
OpenAI API'yi kullanabilmek için bir **API anahtarına** ihtiyacınız olacak. API anahtarınızı OpenAI üzerinden alabilirsiniz. API anahtarını güvenli bir şekilde saklamak için **`.env`** dosyasını kullanın.

### 3. Projeyi İzlemeye Başlayın
Projeyi çalıştırmak için aşağıdaki komutu kullanın:
```bash
dotnet watch run
```


