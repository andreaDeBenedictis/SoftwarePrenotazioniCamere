# SoftwarePrenotazioniCamere
Titolare -> Andrea De Benedictis

Contributori -> Andrea De Benedictis - Samuele Arcangeli

Diario di bordo -> https://docs.google.com/document/d/1xkJrRuF2zDQSBOlJ_RubuVXROAr69qdRau0wnJ8FLsw/edit?usp=sharing

Diagramma di Gantt -> https://docs.google.com/spreadsheets/d/1Z77nHhZ8kUrcTdD8WWOezdMV4wD8zon0iHgYNs_IJHU/edit?usp=sharing

Descrizione -> Software per la gestione delle prenotazioni delle camere di un albergo.
I clienti sono individuati da: codice fiscale, cognome, nome, città, provincia, e-mail,
telefono e cellulare. Ogni camera è individuata da un numero, una descrizione e la
tipologia (singola, doppia).
La prenotazione effettuata da un cliente si riferisce ad una sola camera. Per ogni
prenotazione si deve memorizzare la data della prenotazione, un numero progressivo
nell’anno, l’anno, il periodo di soggiorno (dal, al), la caparra confirmatoria e la tariffa
applicata. La tariffa applicata dipende dal tipo di camera (singola, doppia), dal trattamento
(mezza pensione, pensione completa, pernottamento con prima colazione) e dal periodo
dell’anno (dal, al).
Durante il soggiorno possono essere richiesti servizi aggiuntivi (Colazione in camera,
bevande e cibo nel mini bar, internet, letto aggiuntivo, culla) da caricare sulla
prenotazione. Per ogni servizio è memorizzata la data, la quantità e il prezzo. Sui servizi è
specificato il prezzo (comprensivo di unità euro oppure euro/giorno), una descrizione.
Il nostro software servirà a gestire le prenotazioni delle camere di un albergo.

Soluzione-> Il software deve:
- Consentire di caricare una nuova prenotazione
- Ricercare una prenotazione per numero e anno
- Ricercare le prenotazioni per:
    1. Cognome e/o Nome cliente
    2. Data prenotazione
- Per ogni prenotazione stampare una scheda riassuntiva con tutti i dati significativi
- Per ogni prenotazione stampare una scheda riassuntiva dei costi, il totale, la
caparra e il saldo finale da pagare
