#include <iostream>
using namespace std;

#define N 50
//Compiler version g++ 6.3.0
struct stack{
  int T;
  int s[N];
};

void Push(stack &nx, int x);
int Pop(stack &nx);
int  IsEmpty(stack nx);
int Top(stack nx);

int main()
{
    stack nx={-1};
    int n1,thuong;
    cout<<"nhap so";
    cin>>n1;
    thuong=n1;
    while(thuong){
      Push(nx, thuong%2);
      thuong/=2;
    }
    cout<<"ket quả là "<<n1<<endl;
    while(!IsEmpty(nx)){
      cout<<Pop(nx);
    }
    cout <<"Hello, Dcoder!";
    return 0;
}


void Push(stack &nx, int x){
    if(nx.T=N){
      cout<<"ngăn xếp đây"<<endl;
      return;
    }
    nx.T++;
    nx.s[nx.T]=x;
}
int Pop(stack &nx){
  if(nx.T==-1){
    cout<<"ngăn xep rông"<<endl;
    return -1;
  }
  return nx.s[nx.T--];
  
}
int  IsEmpty(stack nx){
  if(nx.T==-1){
    return -1;
    }
    return 0;
  }
  int Top(stack nx){
    if(nx.T==-1){
      cout<<"ngan xep rỗng"<<endl;
      return -1;
    }
    return nx.s[nx.T];
  }