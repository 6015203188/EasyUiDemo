package com.nervds.controller;

import com.alibaba.fastjson.JSON;
import com.github.pagehelper.Page;
import com.github.pagehelper.PageHelper;
import com.nervds.po.CoursePagePO;
import com.nervds.pojo.Courses;
import com.nervds.service.BackService;
import com.nervds.vo.CourseVO;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.util.StringUtils;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
public class BackController {

    @Autowired
    private BackService backService;

    @RequestMapping("getLeftTree")
    public String showLeftTree() {
        return "[{\"text\":\"Languages\",\"state\":\"closed\",\"children\":[{\"text\":\"Java\"},{\"text\":\"C#\"}]}]";
    }

    @RequestMapping("getTabData")
    public String getTabsData(CoursePagePO coursePage) {
        // 获取分页参数
        int page = coursePage.getPage();
        int rows = coursePage.getRows();

        Page<Object> objects = PageHelper.startPage(page, rows);
        List<Courses> treeData = backService.getTreeData(coursePage.getSort(),coursePage.getOrder());
        CourseVO courseVO = new CourseVO();
        courseVO.setRows(treeData);
        long total = objects.getTotal();
        courseVO.setTotal(total);

        return JSON.toJSONString(courseVO);
    }


}
