import { RegistrarSimulacaoTarifa } from './registrar-simulacao-tarifa.model';

export class RegistrarTarifa {
    public constructor(
        public idTarifa?: number,
        public idColeta?: number,
        public simulacoes?: RegistrarSimulacaoTarifa[]
    ) {}
}