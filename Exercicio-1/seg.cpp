#include "seg.h"

seg::seg()
{

}
void seg::setSeq(string t){
    par = t;
}

bool seg::ver(){
    stack<char> a;

    for(int i = 0; i < par.length(); i++){
        if(a.empty()){
            a.push(par[i]);
        }else{

            switch (a.top()) {
            case '{':
                    //so poderia ser o seu fechamento ou abertura de menores
                    if(par[i] != '[' && par[i] != '(' && par[i] != '}'){
                        return false;
                    }else{
                        //caso fechamento, desempilha
                        if(par[i] == '}'){
                            a.pop();
                        }else{
                            a.push(par[i]);
                        }
                    }

                break;
            case '[':
                    if(par[i] != '(' && par[i] != ']'){
                        return false;
                    }else{
                        //caso fechamento, desempilha
                        if(par[i] == ']'){
                            a.pop();
                        }else{
                            a.push(par[i]);
                        }
                    }

                break;
            case '(':
                if(par[i] != '(' && par[i] != ')'){
                    return false;
                }else{
                    //caso fechamento, desempilha
                    if(par[i] == ')'){
                        a.pop();
                    }else{
                        a.push(par[i]);
                    }
                }

                break;
            }
        }
    }
    if(!a.empty()){
     return false;
    }
    return true;
}
