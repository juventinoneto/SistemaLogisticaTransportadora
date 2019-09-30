export class ExpedicaoCalendarData {
    public constructor(
        public data?: Date,
        public destinatario?: string,
        public diasRestantes?: number,
        public idColeta?: number
    ) {}
}