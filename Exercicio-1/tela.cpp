#include "tela.h"
#include "pri.h"
#include "seg.h"
#include "ter.h"
tela::tela()
{

}
void tela::mostraTela(){
    setlocale(LC_ALL, "Portuguese");
    pri a;
    seg b;
    ter c;
    string sequencia;
    int soma;

    do{
        do{
            cout<<"Escolha uma das questoes para que seja calculada a resposta\n";
            cout<<"1 : Exercicio 1.1\n";
            cout<<"2 : Exercicio 1.2\n";
            cout<<"3 : Exercicio 1.3\n";
            cout<<"4 : Sair\n";
            cin>>opc;

            if(opc < 1 || opc >4){
               cout<<"Forneca um valor valido de acordo com as opcoes\n";
               Sleep(3000);
               std::system("cls");
            }

        }while(opc < 1 || opc >4);


        switch(opc){
            case 1 :a.preencherMatriz();
                    sequencia = a.proMenor();
                    cout<<"O menor percurso da piramide seria "<<sequencia[0];
                    soma = sequencia[0]-48;
                    for(int i =1 ; i< sequencia.length(); i++){
                        cout<<"+"<<sequencia[i];
                        soma += sequencia[i]-48;
                    }

                    cout<<" e sua soma : "<<soma<<"\n\n";
                    break;
            case 2 :cout<<"Forneca a sequencia: \n";
                    cin>>sequencia;
                    b.setSeq(sequencia);
                    if(b.ver()){
                        cout<<"A sequencia apresentada e valida\n";
                    }else{
                        cout<<"Essa sequencia nao e valida\n";
                    }


                    break;
            case 3 :
                    cout<<"Forneca a sequencia: \n";
                    cin.ignore(3,'\n');
                    getline(cin,sequencia);
                    c.setSeq(sequencia);
                    c.ver();
                    break;
        }

    }while(opc != 4);
}

