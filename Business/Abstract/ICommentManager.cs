﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICommentManager
    {
        List<Comment> GetCommentById(int productId);
        void AddComment(CommentDTO comment);

    }
}
