package com.example.ok.Controller;

import com.example.ok.Entity.NhanVien;
import com.example.ok.Repo.NhanVienRepo;
import com.example.ok.Service.NhanVienService;
import org.aspectj.asm.IModelFilter;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller; // Đổi sang Controller
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

import java.util.Optional;

@Controller
@RequestMapping("/nhan-vien")
public class NhanVienCtrl {

    @Autowired
    NhanVienRepo nhanVienRepo;

    @Autowired
    NhanVienService nhanVienService;

    @GetMapping("/list")
    public String list(Model model) {
        model.addAttribute("nhanVien", nhanVienService.getAll());
        return "nhan-vien/index";
    }

    @GetMapping("/add")
    public String addForm(Model model) {
        model.addAttribute("nv", new NhanVien());
        return "nhan-vien/add"; // JSP form thêm
    }

    @PostMapping("/add")
    public String add(@ModelAttribute NhanVien nv) {
        nhanVienRepo.save(nv);
        return "redirect:/nhan-vien/list";
    }

    @GetMapping("/delete/{stt}")
    public String delete(@PathVariable("stt") Integer stt){
        nhanVienRepo.deleteById(stt);
        return "redirect:/nhan-vien/list";
  }
    @GetMapping("/update/{stt}")
    public String update(@PathVariable("stt") Integer id, Model model) {
        NhanVien nv = nhanVienRepo.findById(id).orElse(null);
        model.addAttribute("nv", nv);
        return "nhan-vien/update"; // JSP form sửa
    }
    @PostMapping("/update")
    public String update(@ModelAttribute NhanVien nv) {
        nhanVienRepo.save(nv);
        return "redirect:/nhan-vien/list";
    }



}
