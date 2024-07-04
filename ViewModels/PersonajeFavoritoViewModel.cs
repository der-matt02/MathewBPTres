using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MathewBPTres.ViewModels
{
    public class PersonajeFavoritoViewModel : INotifyPropertyChanged
    {
        private string _imagenPersonaje;
        private string _descripcionPersonaje;

        public string ImagenPersonaje
        {
            get => _imagenPersonaje;
            set
            {
                if (_imagenPersonaje != value)
                {
                    _imagenPersonaje = value;
                    OnPropertyChanged();
                }
            }
        }

        public string DescripcionPersonaje
        {
            get => _descripcionPersonaje;
            set
            {
                if (_descripcionPersonaje != value)
                {
                    _descripcionPersonaje = value;
                    OnPropertyChanged();
                }
            }
        }

        public PersonajeFavoritoViewModel()
        {
            ImagenPersonaje = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAMsAAAD4CAMAAAB1y+ICAAABXFBMVEX////+Xgp1QjH927b/YQoeIxl4RDIAAAD/XwAADQ+ALwX92bEXHRB1QzP7XQodJBr/WgD/472PNQXxWQmJMwXWTwjeUgltQDHmVQmyQgefOwaVNwbOTAh3LASEMQXyWgkQFwdISUevQQfBRwemPQbzUQBtOSnoSwD/+/dvKQS6RQft8vTfRwCCiYtCKyRbJxI6IBdiOi43JiB0dHRSMyksIBwsAAD+6tU+AABPGwBwOSa3MQBiJATCOADo6OiXl5e/wcJ5WE6ps7WbIQCqJgBhRj/VuptUJBfnyaeCcl//8eSChIT+5cuYo6bW3d9hLBdGIxdGEgBTRjowGxSMHgB/bWmAVEd/OiBtVlCBHQBpYmF4fX7RPACQHgAZAACckHosCwSynIJsXU05DABxMBZGOC55aVhEPj5TUVLNz9AcGxosLCw5Gg0+KBleJQxBEwbDqo4AHSFUaW1ZWll5B7LRAAAUPElEQVR4nO1d+XfayJYGXE/m4Yce+yK2DuAFLxgwtmPHC8FOk3iLEzub43TSSac7vM4kPdP//zmjkoRAVbdKCxLOzOH7IbYDSPWp7lJ1696LzzfFFFNMMcUUU0wxxRRTTDHFFD8uVjTc9TjGwEXn/PTFy1eJ3NHRsYyjo3exVy9fnJ53Du56ZLbQP3/x6t2D1flIJBgMIh3yH5HI/O1x7uVp9/8EoYvDh9f78xGZgp8BmVRk9biw0f2xpa5/GnowH2SyGCUk8zl6eP6j0rlYC+1HLBHR+Sweve7e9bABdB8eR4LWeeh0Vq/fXtz12I04L6zamREDncjx685dj3+ItTfz9qdkdHL20z+IqJ2/mXc4JUMEbxd+ADbdwuLYTFQ2zf7dMrlo3o4jXUY2+6/v0gpsHLvGxI+twNHaXTHphsZXFILNfKFzF0xWbtwTryGC+zeTXwt03kRcnhQVKFKYtA14u+/BpKgIPpio1qw8cscQw0CLrycnZ/1CxDsmGJHapKxz98gz+RogeN2ZCJXzBx7K1wDoeBJrmrXbCVCRyTw4//9CRSaz7zWZiVHxnswEqWAx81JnzvcnSAUbgI5nVDrHE6Uik3nnlZ+5uJ4wFdnP1DxaAex57iJpRB55QuW1xwsXGItvPaCytnoXVGTL7L4x609a73Uy127H0VcKd6AsKlxXmZs7URYVi+7uzbqT9Pck0JGbXmbljVMqyhnS/GImExeV3x1dJ9h0kYsjCZMHLibLid9+uff+yWyj3tpsrBekStwJHxelrGN7GSYPOJMtXG62m4EPv0aj0ZmP3wVBCIfT7Vajlo3bpeOilNXs2TCESsuFRr0ZDghC7/nj6IyM6M+tBSEgQwiEm63LXMoenaBbtmxt3haRlNRrYR544J/eK0wUPPmkkFH4pOuXkq3ZWXVnL3NwZPmeMpHcZT0dVgctLFz9PKQiT83nhQEbTKf1rWKdDXrjyiLTquIjFK/KRAL60+89nzEiOpwa/Hq43ZBEq2wiGy5Q6VtTfITye61mYDhW4fuIfOlTc7UwwiYgNFvFjDU26NgF9U9bUXwkVr+2w4ZhfviLooLxsTf6roCQbtVSlti4oP7dWytMcldNwTDGhdZjkMpM9P0nwxtlUat/s8TmduwF82/m04KyMhPj+BZIVTHIWSBAstmLm7MJ7o47Laa7FpTptQVicL2P8KSoePx5gfxAerNqTmZ1zIkxnRaUa4XJ59x7wqNCKw3+TPub+cTUxqLSMdEWVNppUsMypTIT/Z0mk/5a8nZiHvGnBaWuyEmxQgV7GopMIHxlRib42xhULvghfZTcpEZkiQqDzFezibntOOfyluvyISqBBa7aj5D5+JT6bHrHbGIeOufC34LFASq7fyydbM/MzfGJzM2cbS992aXmtPkLfxUwhvPnaz66pHQlIGwpS8AlmQ6HyPaScvkrWkAbtTyXTMTxpmyDJ2Io1qSpPOsMPnvCYDM3czJ4S/8+RSYdqy7zyARDTrkUeZfNtAAJG13MboNkTkbecUqpjNASq2XeXfcdHv5f7POm+yvFRB6J4fNLUZLN3JnxDvTjSCdQNcshEzl1xuWcs59EO+TCBUsY+dCIqZk7IV7vP6NcZktEOY7OBAvOuDxkO0oU+2oiYQCZuSXq9Q3KljXLCBUy7Bs/cGbJ2MctKFuu09PyFbjGyRyPim9li7pMD/nRHnti5h1t/DlOPxUrp6lpWQdXS/rMQFR8vkNS/YW6PCkpiXnryAsnXLqLzIezh9bpddhn+DJnDF3R0CAnJp2TJ6YgMkXijRMupyzvghIZP+XyhZ0O4zoqlzPGq+eUXb6U5ySTY00MOnZyhMFU/aSE8pQVE/5gXUdVGeZtSCOiCBkqMIVsteOAS4LBRdZMJFHqss6+RZQtYT5AY9J4i5lkOhkny5gVxkEYyuZlOtRessG+kjwxUc59iFhGILwu3xjVmFwcKH+f4fXxXdAlOS27h5xLzcy85wg56WNkdynfpcryMUHBPheWGavk/X6RVH3hPk8jt6P/4bza3yGCOG35Dv5SjDExTgzZGmzGFK1MkZ6SrfkYSz9zD7ZJs4ytMlv70ZH9yPILmIuYkEWsQi73uSLm8z3hrm5PCSELf8NcskkGFwermDBsxvIVLMwEF2GHf/173Ff7O8TVrpSHxhIyB5v+IsgFxUr4H8IkC1v8a/3Jf5mMymIPwxayRfuRJfjUBYUUWSZMsvCFfy3+vPi+EArTrOCbSAxLZn91ecBwL3ivib4RXHb5O6SDG/69SIVJK0vLFGODad9ZMjaVGeyUUY/kQj+q0z+H/A6GG5uDtVPaencJ1x9WxEsRAVe49OEYDPYudASGXsDcm52d/VsnoP+2Iv/3LEWG9DCK52dzsb1NhgP8SIrjH6RH2CFtrjLmWf1P3fsc4v+mxnJABmQaCpdcHOZi+7QPdvso4Qe4ACbZyEX3PjAXH8FFaA1lwEMu6rwT8RPhGSU2XXnMHfqqsIyR635lRabpphtczsfj4jsYrQffHpI5PASWIOQ811XpguNzDvTFFhe+2z/hLPk5XBjKb9+OMZbJCZALpftGnMFxiyG+e8sFjouX1H04acc4m0qMublt7uuU7mtciuDjtO/34a1YXPHI1FbsKffyOKzEvdfBM5KLckKGYiAX+yd9B2B0TONC+X2uOspU+BPTWTdeTrPJKAdGlhyEx8G1pcblNztrSyVANse71SG1S0ZsLk6CSiFoza/qCyqSXDhrfi0Ky4qPYdyQUeVLxJYxdG2bCiM8pmyQqL0YvYjRsaTFYHlSRobIlI0lfmSQaDiJXYBhS81M5tsEF7bCsA8sdJBLy0BYvQtsk53ElEDHr10+Th4CgTF+AxUOGXL7okb7WFycBPpBo6xdno6PwR5miX+UpIEM9qlBJd2ZEbh1cMq3AhkylFBMC6pRcUvIkp0QZ3ywzpA7scHSUgmT0CNwEFLy+QRA+VE5pfzIksoPLcnOqMPXuSiwmKEOLcM9dfIlaP/iRPUZSRepLKwwgV1yYshJYU1Nl3CU+GCcp/qODl/h1aVqJ1GPHABx8MpMVpibIdhQB59CW4vygVycpcSAkZiB8ktUosIwDLt0csZLIpmbOxsxApQRk3fI6q2SUNYCeucstxfy/IPQKC1kgfXDpZOT7e0z02wYTCe6fXKyJAPMvdC8PpSC5TS7B0whEdUdDBUiw5mvj+fMaYzwwfgv+ji6rsb44Lils2NkhsKgkPqDPuULBOqWiWiIPlmgLqItYOCTMWenlT7WyZh2DwQkKyw8t5Y7plP56zswLaqjREVokRwMO6MCe5jB6Rsq02lKlhPhBqCzrrQ4nyzLri1gVMDHSRXNHQMDEWyRiT6nJUyoq7YFjow7FjFW5sVgYqiFf4CfZE1ReU+nXAbS2pkrfPYafOmUCis7uaIZfiplQiHz2SqVn8k1Jf74pmqIUTUF3XlxjCoYWMhQTf1RofN7AkomvyUujyEZbQ+MFzgtTh2lggv4ECajebMCneCDccUoSzDiM/DJtGaPUQw8R3KW1zMAnGuNcpoEANmj+OluweUiBgkD9D4gXImGh0VinPRkZmnCIMGr1IDJfKLLeAgqHyEqm1rtCCN/bKy0cR8jGiM/OM36l77CZHq/c8nIswIoS0vLTUQSfBzu3LmoOIRzLtGyZsvEHlWboIyLb85gKhVtNpJwwtVYmo+xwkhURMWBPBRBaxYw1vAZ8RkQsMDmIGNUZGQojl/9xiquRHvaDhblG/DUfPoVJBN93ALcfboxyH5He3BOnwvFb6yJ8fsH90T+XCsNuc3e7xCVvz5AfqWmD5mVBBsxOVgfZ2JkWRg8QBQvtMLQ6uwz5Wmi74GlcfNqoCqyyDKSk12pSfQxOyoMyfhRpgDODVWYCFRXpVsxv04lxsqzdqVWlFOVKI6U36F4wlAqqg30+2hlT5SqesOlvIWRiyQqDCroyJ2uF4/Y5Ra15PDeyJ/tjZTwDuTsuS5n0V8NqiII4XS7ERupRkSFJEs5512q4L9gF1ejxGiwBKFUrEHR0eVsWPAmCAFcyt/LJQ3V1XvMSh6nafw0DtlZ12jZeLCAUDJ22Wqmce2+Qc7UAn61IUGz3bqsSXnRQARl9ti1b+PXvOrglPPJQyCeJkLxSmyvsVlvy5QwFHv2/pOgkNjs1WLLSZHqFIGyjPQXDDfs8QAHvK5QKETlRyhNOjL5ZSlR2FvvXTauZv+8/7QWq1ZScbiBBxJrLK3Hr7pTvK+B21MF5RnlxMN29lWpwutCgrI1TiE/clHCMDb4fSISOX6LhAIKcWpaUnucSZFtmIsSpqDJL7VMcWUE795ZNS3yokHiPohxty00Vt6YlPNWakznoKSaV6CTIdl0hGL8PhHudu1R0Tdp4YFQuZaHH3AeOyHgOEU24IWcSccLdOtFN8WuWeMLJKvwsh8wUgXl3xBpukvVWhZ4uxHzrqzDKJg3hEQoX4hRbWzUowEDF5lIthDLmPdU8ajHnWzM2P5/OMpStZBL+UdHuaxEu3Uu8kspqRBLWmkO41nvQZ/vxkoHH/zMQ6Gq4tvxeLUcTVRU/oznpUKxbGFGlM9ce9h7+LW1dkS4NdRyLBRKVJfzqXhBjMczqeReNhcKFaW89U5XXvbqlPHIcm8ldR2TrCyXdyRJqmYrtUzJXgMyb0yYIzI6p6K6jknYoKFg1Yt2kOOR0XI0mTUgLMT/Nh/MuLiB07nZY1KLWEVmySQMsfbKey4PaxbbOWnQzuntcvk2dm8bc5yvcrblAPSKPHv6sieO33TIDDj2h2LcRg4EF+2cnlU2AUINV7m8b6GgdFZDZesCE4/Z51JSI2/BtKdUtGAZyjPrUgmg2iBUC2dOQx/J7Gm/Oe1uYQ2DICaKW2mzhbc1A3FkV7JSH9FnMPjaQyqjweUCd2OrIT7MamGUgFBUYsM6MacdIazA0FIRlS1YpvzwAIJTxz5y0fjeaJM4d6LIIIwtFenQGH+YrCLD0fdUQ8a/HWVXWgHVUhEl2I0paJS4vXP8ysMhw/xuxZEpNKnwBUruWeuCqLy5yG0whvwxOundWXsLc4CHF0gqWu63yZsYHCyAJHactBEOnsKJC2bxrZG35lgTg1CFEi8V7kfHMJgtFVGqVjWNp6jvZP13lh0qHC/ZgoEFTrA/ZSmoAn8WZWK8xaoX/tKksVpJKlRt93iWiYjlglTifcydQ1cjXpt0upSfb66QS/qt81GCZAnTrtBO23SxwUi/IgYXXy6GcvmSeYhCC5JZaW/tvllmtPKgx4jilVwoJFUyIivqgnlUQyHLbcdd31++stFzHBPKV2OhED4JK4loBP5SqpIrFLMZG9GlcTpBQjDp2gkTQiI+55M5hYoxSYol8C+5ctJEBKl0mDGyX0HQ/e5ERs8TgBIe+3Je+7IBs2cCNLlxeVFGV/XBZ0NMShVr1MG9tMtBjHfUUXHCDhU/WrbMhd5Lo2M3V/50IZylnZUjLmU6NdlRzzEWAHWxF1K1zgXqpeK8dSoAurkSoxkFk0sWTAQHQW+9x0tMJkB5F/byfWwukPI7Kt6DQdda2opC+mEtYL2VtipuLmMA1Tfbu4/BhX4reuceF2O1leLxbM+LxUifHyrgc9PzqzXjykEqQqlyLFcR7c6L1ailH6pDRvvu7WGw10ep0GWj0Qut15vpdLO14x2XoSHTlzxOCqoZeBVE8T2cfCgIm2ryrtC2cWyhcLF+mjaoR0WpajFWUaI8LjrLdyivchCaeo74undciiiTKZWkS1UCChnk4hbm4EFeK3MVGnoW66Y9LmDRN/zW0s5lvd76T13N2MT5y8hBXzsG+g8G9VCCXiMmbNqhYodLalMRZqE5qEYVmpfuzUv3/qDKZXRePOKiVwcP7xUI/+Ial8NLPeM4rT8sm/pincug/4Ssm8O8bG4vUDt4O6xLF640O9b84DWX4XMLgL3MncFQrXOVVoS5UbfhMGxx0XsAN0fqaoT77nhLY+smQfaYjUZbaHK/E4AaIaP5HvDOQT2tcDla8ujSxHSMjUKwqcQJ+bZWZDb2CBmtCbBgKCYVPrnChWzdpNmWbx5xSf2ziaVYFmbDEzTpPfdjckm2m1iKG0RtkEm/tvG42MpvQZJlLvm2oIC431NXuNBt5zHaVo73h1zgvmgQkkD3CdfmhexvrMqvTb9vnQvVNFu9nzv6QjVvwmjaSwezwUUEvljGNTsGfOeM1nvaBpeYZS50TyCMXbeKLagnJWxaD3fZ5pIlO7UFoO+WcYqDDwZTJu8u+V/RNBYX8EulqNZTzrHyx7eBkRSE3Wf/vWj7NMYGF93zjzy9LTePYLpXO7uy0d/d3dnaOOi8vN6ft5c3bedYgPoSNuF+x0UqMvprN8+/3BxqcnvxP6GQUlZoMeXCFhdUmd0dWSPvbrlMhcR5BNcehopVoMDQORccRcpUrh/2N+7vqu5/9+nWjWfFFjoX5dZ+XIRQlPImufoWuCDtYqHyNR77xcbX+8+ebdU3ul4z0bgMxqCcg8eWU+xzcF7mKFIPnouhYlmZ5Aeaoh9cuHvoas5FH4+YLMtTlFtOQXO0zCLhz+SlhJIQ4Nc+5WWWpSUu+thKSVznkpAqqdLot9Qj47vUk341ByCvs9Be/yG4jDzteD6bK8qcctVKPhUvibJ7EUWxFMcVMRJ+pZjL5uHcjDvgYlY7oj19efBZKZeLJRKJWC4nlTE1cXTGaLgY1XeJC8FKzyIxx4/MxS68TX2fcnEKF0+OplzcA5owlxWZC/YZRhtlBuOYRRolDNGTNF4W8LeIzP7TO4BfRuIN+rP/kPFvD/GPn7wrFjGiq3DxFP+aQKGogoPZnzD+5Qzy534yxazHpchD9A9PNzZu/v5yj4sv977o+JvAjYINBt6eel4mOsUUU0wxxRRTTDHFFFNMMcUUU0wxefwv8ey6e3/Lw/MAAAAASUVORK5CYII="; // Reemplaza con la URL de la imagen de tu personaje favorito
            DescripcionPersonaje = "A mi, Mathew Baquero, me gusta este personaje porque no se le entiende cuando habla, debido que la capucha de su abrigo está muy ajustada. Serie: South Park";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
