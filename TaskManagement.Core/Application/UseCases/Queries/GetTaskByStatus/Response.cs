﻿using Task = TaskManagement.Core.Domain.TaskAggregate.Task;

namespace TaskManagement.Core.Application.UseCases.Queries.GetTaskByStatus;

public class Response
{
    public IEnumerable<Task> Tasks { get; set; }

    public Response(IEnumerable<Task> tasks)
    {
        Tasks = tasks;
    }
}