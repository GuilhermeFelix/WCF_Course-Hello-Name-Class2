using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "HelloService" no arquivo de código e configuração ao mesmo tempo.
    public class HelloService : IHelloService
    {
        public string GetMessage(string name)
        {
            return ("Hello ") + name;
        }
    }
}
