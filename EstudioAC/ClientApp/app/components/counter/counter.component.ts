import { Component, Inject } from '@angular/core';
import { Http, HttpModule } from '@angular/http';
import { Request } from '@angular/http';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import { Observable } from 'rxjs'


@Component({
    selector: 'counter',
    templateUrl: './counter.component.html'
})
export class CounterComponent {

    //private http_ : Http;
    private caminho_: string;

    public teste = [{
        servicoPrestado: "",
        valor: "",
        date: ""
    }]

    public servicos = [
        { nome: 'Corte Masculino', viewValue: 'Steak' },
        { nome: 'Corte Feminino', viewValue: 'Pizza' },
        { nome: 'Escova', viewValue: 'Tacos' }
    ];

    public dados = [];

    constructor(private http: Http, @Inject('BASE_URL') private baseUrl: string) {

        //this.http_ = http;
        this.caminho_ = baseUrl;

        http.get(baseUrl + 'api/sistema').subscribe(result => {
            this.dados = result.json();
            console.log(this.dados);
        }, error => console.error(error));
    }

    

    salvar() {
        this.http.post(this.caminho_ + 'api/sistema', this.teste)
        .map(success => success.status);
        //return this.http.post(this.caminho_ + 'api/sistema', this.teste)): Observable<Response>
    }
}

interface Counter {
    servicoPrestado: string;
    valor: string;
    data: string;
}

