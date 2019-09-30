export class ResultBase {
    public constructor(
        public sucesso?: boolean,
        public object?: any,
        public mensagem?: string
    ) {}
}