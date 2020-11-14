package by.naxa.testdome.service;

import java.util.Date;
import java.util.UUID;

interface AlertDAO {
    UUID addAlert(Date time);
    Date getAlert(UUID id);
}
