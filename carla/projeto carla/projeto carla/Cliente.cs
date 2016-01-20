using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_carla
{
    public class Cliente
    {
        public int cod;
        public String nome;
        public String cpf;
        public String tel1;
        public String tel2;
        public String tel3;
        public String tel4;
        public String uf;
        public String cidade;
        public String bairro;
        public String logradouro;
        public String endereco;
        public String numero;
        public String complemento;
        public String cep;
        public String email;
        public String dataCriacao;
        public BancoDeDados bancoDeDados = new BancoDeDados();

        public void preencherDataCriacaoComDataDeHoje()
        {
            this.dataCriacao = new DateTime().Day + "/" + new DateTime().Month + "/" + new DateTime().Year;
        }

        public bool cadastrar()
        {
            return this.bancoDeDados.executarComando("INSERT INTO `databasecarla`.`clientes`(`codcli`,`nomecli`,`cpfcli`,`tel1cli`,"+
                "`tel2cli`,`tel3cli`,`tel4cli`,`ufcli`,`cidadecli`,`bairrocli`,`tipodelogradourocli`,`enderecocli`,`numerocli`,"+
                "`complementocli`,`cepcli`,`emailcli`,`datacriacaocli`)VALUES('"+cod+"','"+nome+"','"+cpf+"','"+tel1+"','"+tel2+"','"+
                tel3+"','"+tel4+"','"+uf+"','"+cidade+"','"+bairro+"','"+logradouro+"','"+endereco+"','"+numero+"','"+complemento+"','"+cep+"','"+
                email+"','"+dataCriacao+"');");
        }

        public bool modificar()
        {
            return this.bancoDeDados.executarComando("UPDATE `databasecarla`.`clientes` SET `nomecli` = '"+nome+
            "',`cpfcli` = '"+cpf+"',`tel1cli` = '"+tel1+"',`tel2cli` = '"+tel2+"',`tel3cli` = '"+tel3+"',`tel4cli` = '"+tel4+"',"+
            "`ufcli` = '"+uf+"',`cidadecli` = '"+cidade+"',`bairrocli` = '"+bairro+"',`tipodelogradourocli` = '"+logradouro+"',"+
            "`enderecocli` = '"+endereco+"',`numerocli` = '"+numero+"',`complementocli` = '"+complemento+"',`cepcli` = '"+cep+"',"+
            "`emailcli` = '"+email+"',`datacriacaocli` = '"+dataCriacao+"' WHERE `codcli` = "+cod+";");
        }

        public bool excluir()
        {
            return this.bancoDeDados.executarComando("DELETE FROM clientes WHERE codcli = "+this.cod);
        }
    }
}

