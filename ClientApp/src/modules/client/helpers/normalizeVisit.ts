import {Visit, VisitPriority, VisitStatus, VisitType} from '../api/visitAPI.types';

export const normalizeVisit = ({
    visitId,
    date,
    price,
    requiredActions,
    licensePlate,
    priority,
    type,
    status,
    assignedEmployees,
    carOwnerUsername,
}: Visit): Visit => ({
    visitId: visitId ?? 0,
    date: date ?? '',
    price: price ?? generatePrice(),
    requiredActions: removeEmptyStringsFromArray(requiredActions) ?? [],
    licensePlate: licensePlate.toUpperCase() ?? '',
    priority: VisitPriority[priority.toUpperCase() as keyof typeof VisitPriority] ?? '',
    type: VisitType[type.toUpperCase() as keyof typeof VisitType] ?? '',
    status: status !== undefined ? VisitStatus[status.toUpperCase() as keyof typeof VisitStatus] : VisitStatus.ATSERVICE,
    assignedEmployees: assignedEmployees ?? [],
    carOwnerUsername: carOwnerUsername ?? '',
});

const removeEmptyStringsFromArray = (array: string[]) => array.filter((x) => x.length !== 0);

const generatePrice = () => (Math.random() * 1000 + 100).toFixed(2);
