export interface Pagination {
  currentPage: number;
  itemsPerPage: number;
  totalItems: number;
  totalPages: number;
}

export class PaginatedResults<T> {  /* we use generic type here cause we will use pagination for photos and messages too*/
  result: T;
  pagination: Pagination;
}
