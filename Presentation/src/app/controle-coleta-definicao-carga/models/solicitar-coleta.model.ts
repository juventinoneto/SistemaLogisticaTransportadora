import { SolicitarColetaCliente } from './solicitar-coleta-cliente.model';
import { SolicitarColetaParceiro } from './solicitar-coleta-parceiro.model';
import { Endereco } from 'src/app/models/endereco.model';

export class SolicitarColeta {
    public constructor(
        public cliente?: SolicitarColetaCliente,
        public parceiro?: SolicitarColetaParceiro,
        public data?: Date,
        public nomeDestinatario?: string,
        public endereco?: Endereco
    ) {}
}