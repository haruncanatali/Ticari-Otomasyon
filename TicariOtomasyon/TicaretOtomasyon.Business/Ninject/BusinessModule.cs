using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretOtomasyonu.Business.Abstract;
using TicaretOtomasyonu.Business.Concrete;
using TicariOtomasyon.DataAccess.Abstract;
using TicariOtomasyon.DataAccess.Concrete;

namespace TicaretOtomasyonu.Business.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IAdminService>().To<AdminManager>().InSingletonScope();
            Bind<IAdminDal>().To<AdminDal>().InSingletonScope();

            Bind<IBankaService>().To<BankaManager>().InSingletonScope();
            Bind<IBankaDal>().To<BankaDal>().InSingletonScope();

            Bind<IIlService>().To<IlManager>().InSingletonScope();
            Bind<IIlDal>().To<IlDal>().InSingletonScope();

            Bind<IIlceService>().To<IlceManager>().InSingletonScope();
            Bind<IIlceDal>().To<IlceDal>().InSingletonScope();

            Bind<IFirmaService>().To<FirmaManager>().InSingletonScope();
            Bind<IFirmaDal>().To<FirmaDal>().InSingletonScope();

            Bind<IOzelKodService>().To<OzelKodManager>().InSingletonScope();
            Bind<IOzelKodDal>().To<OzelKodDal>().InSingletonScope();

            Bind<IFaturaService>().To<FaturaManager>().InSingletonScope();
            Bind<IFaturaDal>().To<FaturaDal>().InSingletonScope();

            Bind<IFaturaDetayService>().To<FaturaDetayManager>().InSingletonScope();
            Bind<IFaturaDetayDal>().To<FaturaDetayDal>().InSingletonScope();

            Bind<IGiderService>().To<GiderManager>().InSingletonScope();
            Bind<IGiderDal>().To<GiderDal>().InSingletonScope();

            Bind<IMusteriService>().To<MusteriManager>().InSingletonScope();
            Bind<IMusteriDal>().To<MusteriDal>().InSingletonScope();

            Bind<INotlarService>().To<NotlarManager>().InSingletonScope();
            Bind<INotlarDal>().To<NotlarDal>().InSingletonScope();

            Bind<IPersonelService>().To<PersonelManager>().InSingletonScope();
            Bind<IPersonelDal>().To<PersonelDal>().InSingletonScope();

            Bind<IUrunService>().To<UrunManager>().InTransientScope();
            Bind<IUrunDal>().To<UrunDal>().InTransientScope();
        }
    }
}
