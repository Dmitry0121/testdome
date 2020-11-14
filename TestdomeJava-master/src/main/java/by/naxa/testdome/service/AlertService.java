//  Created by naXa! on 18/02/2019.
//  Copyright © 2019 naXa!. All rights reserved.
//
/*
 This code is a practice Java interview question from testdome.com
 Problem statement: Refactor the AlertService and MapAlertDAO classes:

* Create a new package-private interface, named AlertDAO, that contains the same methods as MapAlertDAO.
* MapAlertDAO should implement the AlertDAO interface.
* AlertService should have a constructor that accepts AlertDAO.
* The raiseAlert and getAlertTime methods should use the object passed through the constructor.
 */
package by.naxa.testdome.service;

import java.util.Date;
import java.util.UUID;

class AlertService {
    private final AlertDAO storage;

    public AlertService(AlertDAO storage) {
        this.storage = storage;
    }

    public UUID raiseAlert() {
        return this.storage.addAlert(new Date());
    }

    public Date getAlertTime(UUID id) {
        return this.storage.getAlert(id);
    }
}
