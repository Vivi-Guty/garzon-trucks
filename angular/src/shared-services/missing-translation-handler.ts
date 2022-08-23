import {MissingTranslationHandler, MissingTranslationHandlerParams} from '@ngx-translate/core';

export class CustomizedMissingTranslationHandler implements MissingTranslationHandler {
    handle(params: MissingTranslationHandlerParams) {
        return 'No translation found!';
    }
}
