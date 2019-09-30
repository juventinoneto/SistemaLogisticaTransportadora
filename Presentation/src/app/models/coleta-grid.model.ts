import { Endereco } from "./endereco.model";
import { Cliente } from "./cliente.model";
import { Expedicao } from "./expedicao.model";
import { Tarifa } from '../controle-tabela-frete/models/tarifa.model';

export class ColetaGrid {

    public constructor(
        public idColeta?: number,
        public idCliente?: number,
        public cliente?: Cliente,
        public idParceiro?: number,
        public parceiro?: Cliente,
        public data?: Date,
        public nomeDestinatario?: string,
        public idEndereco?: number,
        public endereco?: Endereco,
        public expedicao?: Expedicao,
        public status?: string,
        public tarifas: Tarifa[] = []
    ) {}

}