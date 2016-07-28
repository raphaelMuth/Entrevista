#include "ter.h"

ter::ter()
{

}
void ter::setSeq(string t){
    seq = t;
}

void ter::ver(){
    int temp;
    locale loc;
    //primeira verificação
    if(seq.empty()){
        //caso esteja vazio
        cout<<"Entrada invalida!\n";
    }else{
        //retira espacos, letras e outros caracteres indesejados
        for(int i = 0; i<seq.size(); i){
            if(!isdigit(seq[i],loc)){
                if(seq[i] != '+' && seq[i] != '-'){
                    for(int j = i; j<seq.size()-1;j++ ){
                        seq[j] = seq[j + 1];
                    }
                    seq.pop_back();
                }else{
                    if((seq[i] == '+' || seq[i] == '-') && i!= 0){
                        for(int j = i; j<seq.size()-1;j++ ){
                            seq[j] = seq[j + 1];
                        }seq.pop_back();
                    }else{i++;}

                }
            }else{i++;}
        }
        if(seq.empty()){
           cout<<"Entrada invalida!\n";
           return;
        }
        //ver se causa estouro de tipo
        try{
            temp = stoi( seq, nullptr, 10);
        }catch(std::out_of_range er){
            cout<<"Valor estoura o maximo que o tipo permite\n";
            return;
        }

        cout<<"Esse e seu numero apos processamento : "<<temp<<"\n";
    }
}
